using System;
using System.Collections.Generic;

namespace mate22
{

	
	public interface IResultadoGestor : IDisposable
	{
		void Guardar(Resultado resultado);
		List<Resultado> ObtenerTodos();
		List<Resultado> ObtenerPorUsuario(string usuario);
		List<Resultado> ObtenerPorFecha(DateTime fecha);
		List<Resultado> ObtenerPorRangoFechas(DateTime fechaInicio, DateTime fechaFin);
		double ObtenerPromedioScores(string usuario);
		void EliminarPorUsuario(string usuario);
		Dictionary<string, object> ObtenerEstadisticas();
	}
}
