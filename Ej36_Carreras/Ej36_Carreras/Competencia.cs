using System;
namespace Ej36_Carreras
{
	public class Competencia
	{

        public enum TipoCompetencia { F1, MotoCross }
        short cantidadCompetidores;
        short cantidadVueltas;
        List<VehiculoDeCarrera> competidores;
        TipoCompetencia tipo;

        public short CantidadCompetidores
        {
            set => this.cantidadCompetidores = value;
            get => this.cantidadCompetidores;
        }

        public short CantidadVueltas
        {
            set => this.cantidadVueltas = value;
            get => this.cantidadVueltas;
        }

        public TipoCompetencia Tipo
        {
            set => this.tipo = value;
            get => this.tipo;
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            string texto = "";
            //falta

            return texto;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera v1)
        {
            return !(c == v1);
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v1)
        {
            bool retorno = true;
            TipoCompetencia tipoDelVehiculo = v1 is AutoF1 ? TipoCompetencia.F1 : TipoCompetencia.MotoCross;
            if (c.Tipo == tipoDelVehiculo)
            {
                if (c.competidores.Count() == 0)
                {
                    retorno = false;
                }
                else
                {
                    foreach (VehiculoDeCarrera v in c.competidores)
                    {
                        if ((v1 is AutoF1 && (AutoF1)v1       == (AutoF1)v) ||
                            (v1 is MotoCross && (MotoCross)v1 == (MotoCross)v))
                        {
                            retorno = true;
                        }
                    }
                }
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia.cs", "Validación ==");
            }
            return retorno;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v1)
        {
            bool retorno = false;
            
            if (c.competidores.Count() < c.cantidadCompetidores)
            {
                try
                {
                    if (c != v1)
                    {
                        v1.EnCompetencia = true;
                        v1.VueltasRestantes = c.cantidadVueltas;
                        Random rndm = new Random();
                        v1.CantidadCombustible = (short)rndm.Next(15, 100);
                        c.competidores.Add(v1);
                        retorno = true;
                    }
                }
                catch (CompetenciaNoDisponibleException ce)
                {
                    throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia.cs", "sobrecarga +", ce);
                }  
            }
            return retorno;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a1)
        {
            bool retorno = false;
            //falta
            return retorno;
        }
    }
}


