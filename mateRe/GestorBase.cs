using System;

namespace mate22
{
	
	// CLASE ABSTRACTA BASE - HERENCIA
	
	public abstract class GestorBase : IDisposable
	{
		protected bool disposed = false;
		protected string ruta;

		public GestorBase(string ruta)
		{
			if (string.IsNullOrWhiteSpace(ruta))
				throw new ResultadoException("La ruta del archivo no puede estar vacía", null) 
				{ CodigoError = ErrorCode.ArchivoNoValido };
			this.ruta = ruta;
		}

		// Método abstracto a implementar
		public abstract void Inicializar();

		// Validación de datos
		protected virtual bool ValidarResultado(Resultado resultado)
		{
			if (resultado == null)
				throw new ResultadoException("El resultado no puede ser nulo", null)
				{ CodigoError = ErrorCode.ResultadoInvalido };

			if (string.IsNullOrWhiteSpace(resultado.Nombre))
				throw new ResultadoException("El nombre del usuario no puede estar vacío", null)
				{ CodigoError = ErrorCode.UsuarioNoValido };

			if (string.IsNullOrWhiteSpace(resultado.Fecha))
				throw new ResultadoException("La fecha del resultado no puede estar vacía", null)
				{ CodigoError = ErrorCode.ResultadoInvalido };

			if (resultado.ScoreNivel1 < 0 || resultado.ScoreNivel1 > 100 ||
				resultado.ScoreNivel2 < 0 || resultado.ScoreNivel2 > 100 ||
				resultado.ScoreNivel3 < 0 || resultado.ScoreNivel3 > 100 ||
				resultado.ScoreNivel4 < 0 || resultado.ScoreNivel4 > 100)
				throw new ResultadoException("Los scores deben estar entre 0 y 100", null)
				{ CodigoError = ErrorCode.ResultadoInvalido };

			return true;
		}

		public string ObtenerRuta()
		{
			return ruta;
		}

		
			public virtual void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
				}
				disposed = true;
			}
		}

		~GestorBase()
		{
			Dispose(false);
		}
	}
}
