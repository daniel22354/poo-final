using System;

namespace mate22
{

	public class Resultado : IComparable<Resultado>, IEquatable<Resultado>
	{
		public string Nombre { get; set; }
		public string Fecha { get; set; }

		public int ScoreNivel1 { get; set; }
		public int ScoreNivel2 { get; set; }
		public int ScoreNivel3 { get; set; }
		public int ScoreNivel4 { get; set; }

		public string TiempoTotal { get; set; }

		// Cálculos de scores
		public double ObtenerScorePromedio()
		{
			return Math.Round((ScoreNivel1 + ScoreNivel2 + ScoreNivel3 + ScoreNivel4) / 4.0, 2);
		}

		public int ObtenerScoreMaximo()
		{
			return Math.Max(Math.Max(ScoreNivel1, ScoreNivel2), Math.Max(ScoreNivel3, ScoreNivel4));
		}

		public int ObtenerScoreMinimo()
		{
			return Math.Min(Math.Min(ScoreNivel1, ScoreNivel2), Math.Min(ScoreNivel3, ScoreNivel4));
		}

		
		// SOBRECARGA: IComparable
		
		public int CompareTo(Resultado other)
		{
			if (other == null)
				return 1;

			double thisPromedio = this.ObtenerScorePromedio();
			double otherPromedio = other.ObtenerScorePromedio();

			return otherPromedio.CompareTo(thisPromedio);
		}

		
		// SOBRECARGA: IEquatable
		
		public bool Equals(Resultado other)
		{
			if (other == null)
				return false;

			return this.Nombre == other.Nombre &&
				   this.Fecha == other.Fecha &&
				   this.ScoreNivel1 == other.ScoreNivel1 &&
				   this.ScoreNivel2 == other.ScoreNivel2 &&
				   this.ScoreNivel3 == other.ScoreNivel3 &&
				   this.ScoreNivel4 == other.ScoreNivel4;
		}

		public override bool Equals(object obj)
		{
			if (obj is Resultado resultado)
				return Equals(resultado);

			return false;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Nombre, Fecha, ScoreNivel1, ScoreNivel2, ScoreNivel3, ScoreNivel4);
		}

		
		// SOBRECARGA: OPERADORES

		public static bool operator ==(Resultado left, Resultado right)
		{
			if (left is null)
				return right is null;

			return left.Equals(right);
		}

		public static bool operator !=(Resultado left, Resultado right)
		{
			return !(left == right);
		}

		public override string ToString()
		{
			return $"{Nombre} - {Fecha} - Promedio: {ObtenerScorePromedio()}";
		}
	}
}
