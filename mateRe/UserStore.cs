using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace mate22
{
	public class UserData
	{
		public string Username { get; set; } = "";
		public string PasswordHash { get; set; } = "";
		public int NivelMaximo { get; set; } = 1;
		public int AciertosTotales { get; set; } = 0;
		public int ErroresTotales { get; set; } = 0;
		public double Score { get; set; } = 0;
	}

	public static class UserStore
	{
		private static readonly object sync = new object();
		private static Dictionary<string, UserData> users = new Dictionary<string, UserData>(StringComparer.OrdinalIgnoreCase);
		private static readonly string filePath;
		private static readonly string logPath;

		static UserStore()
			{
				string appDir = null;
				try
				{
					appDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "mateRe");
					if (!Directory.Exists(appDir)) Directory.CreateDirectory(appDir);
				}
				catch { appDir = null; }

				if (string.IsNullOrEmpty(appDir))
				{
					try
					{
						appDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "mateRe");
						if (!Directory.Exists(appDir)) Directory.CreateDirectory(appDir);
					}
					catch { appDir = null; }
				}

				if (string.IsNullOrEmpty(appDir))
				{
					try
					{
						appDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "mate22");
						if (!Directory.Exists(appDir)) Directory.CreateDirectory(appDir);
					}
					catch { appDir = Path.Combine(Path.GetTempPath(), "mateRe"); try { if (!Directory.Exists(appDir)) Directory.CreateDirectory(appDir); } catch { } }
				}

				filePath = Path.Combine(appDir, "users.json");
				logPath = Path.Combine(appDir, "mateRe_log.txt");
				Load();
			}

		private static void Log(string message)
		{
			try
			{
				var line = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}{Environment.NewLine}";
				File.AppendAllText(logPath, line);
			}
			catch { }
		}

		private static void Load()
			{
				try
				{
					if (File.Exists(filePath))
					{
						var json = File.ReadAllText(filePath);
						var list = JsonSerializer.Deserialize<List<UserData>>(json);
						if (list != null) users = list.ToDictionary(u => u.Username, StringComparer.OrdinalIgnoreCase);
					}
				}
				catch { }
			}

			private static void Save()
			{
				try
				{
					lock (sync)
					{
						var list = users.Values.ToList();
						var json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
						File.WriteAllText(filePath, json);
					}
				}
				catch { }
		}

		public static UserData? GetUser(string username)
		{
			if (string.IsNullOrEmpty(username)) return null;
			users.TryGetValue(username, out var u);
			return u == null ? null : new UserData
			{
				Username = u.Username,
				PasswordHash = u.PasswordHash,
				NivelMaximo = u.NivelMaximo,
				AciertosTotales = u.AciertosTotales,
				ErroresTotales = u.ErroresTotales,
				Score = u.Score
			};
		}

		public static void AddOrUpdateUser(UserData user)
		{
			if (user == null || string.IsNullOrEmpty(user.Username)) return;
			users[user.Username] = new UserData
			{
				Username = user.Username,
				PasswordHash = user.PasswordHash,
				NivelMaximo = user.NivelMaximo,
				AciertosTotales = user.AciertosTotales,
				ErroresTotales = user.ErroresTotales,
				Score = user.Score
			};
			Save();
		}

		public static string HashPassword(string password)
		{
			if (string.IsNullOrEmpty(password)) return string.Empty;
			using var sha = SHA256.Create();
			var bytes = Encoding.UTF8.GetBytes(password);
			var hash = sha.ComputeHash(bytes);
			return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
		}

		public static void SaveUserProgress(string username, int nivelMaximo, int aciertos, int errores, double score)
			{
				if (string.IsNullOrEmpty(username)) return;
				if (!users.TryGetValue(username, out var u))
				{
					u = new UserData { Username = username };
					users[username] = u;
				}
				u.NivelMaximo = Math.Max(u.NivelMaximo, nivelMaximo);
				try { u.AciertosTotales = checked(u.AciertosTotales + aciertos); }
				catch { u.AciertosTotales = Math.Max(u.AciertosTotales, aciertos); }
				try { u.ErroresTotales = checked(u.ErroresTotales + errores); }
				catch { u.ErroresTotales = Math.Max(u.ErroresTotales, errores); }
				u.Score = Math.Max(u.Score, score);
				Save();
			}

		public static System.Collections.Generic.List<UserData> GetAllUsers()
		{
			return users.Values.Select(u => new UserData
			{
				Username = u.Username,
				PasswordHash = u.PasswordHash,
				NivelMaximo = u.NivelMaximo,
				AciertosTotales = u.AciertosTotales,
				ErroresTotales = u.ErroresTotales,
				Score = u.Score
			}).OrderBy(u => u.Username, StringComparer.OrdinalIgnoreCase).ToList();
		}

		public static string GetStoragePath()
		{
			return filePath;
		}

		public static string? GetLogPath()
		{
			try { return logPath; } catch { return null; }
		}
	}
}
