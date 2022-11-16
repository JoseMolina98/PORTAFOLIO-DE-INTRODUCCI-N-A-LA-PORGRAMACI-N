using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S11_01_JMML_1308819
{
    internal class cFormulario
    {
        string _nombre, _nacionalidad, _genero, _carrera;
        int _edad;
        //Tenemos que declara el constructor 
        public cFormulario()
        {
            _nombre = "";
            _nacionalidad = "";
            _genero = "";
            _carrera = "";
            _edad = 0;
        }

        //Metodos Get
        public string getNombre()
        {
            return _nombre;
        }
        //Método Set
        public void setNombre(string nombre)
        {
            _nombre = nombre; 
        }
        public string getNacionalidad()
        {
            return _nacionalidad;
        }
        public void setNacionalidad(string nacionalidad)
        {
            _nacionalidad = nacionalidad;
        }
        public string getGenero()
        {
            return _genero;
        }
        public void setGenero(string genero)
        {
            _genero = genero; 
        }
        public string getCarrera()
        {
            return _carrera;
        }
        public void setCarrera(string carrera)
        {
            _carrera = carrera;
        }
        public int getEdad()
        {
            return _edad; 
        }
        public void setEdad(int edad)
        {
            _edad = edad; 
        }
    }
}
