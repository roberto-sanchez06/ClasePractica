using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Terrestre : MediosDeTransporte
    {
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        //el enum se puede crear aqui
        /*public enum Transmision{
            Mecanica, Automatica
        }*/
        protected Transmision Transmision { get; set; }
        public Terrestre(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
    }
}
