using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarLibrary
{
    public class Persona      
    {                                      
        static int lastId;
        int id;
        string nombre;
        string apellido;
        float sueldo;
        Random rnd;
        int dni;
        bool esAdmin;
        string pass;

        static Persona()
        {
            lastId = 1;
        }
        Persona(string nombre,string pass, string apellido,float sueldo)
        {
            this.nombre = nombre;
            this.pass = pass;
            this.apellido = apellido;
            this.sueldo = sueldo;
            rnd = new Random();
        }
        public Persona(string nombre,string apellido ,float sueldo, string pass,bool esAdmin):this(nombre,pass,apellido,sueldo)
        {
            this.id = lastId;
            this.esAdmin = esAdmin;
            dni= rnd.Next(30000000,45000000);
            lastId++;
        }

        public bool CheckearUsuario(string nombre, string pass, bool esAdmin)
        {
            return this.nombre == nombre && this.pass == pass && this.esAdmin == esAdmin;
        }

        public string Nombre { get { return nombre; } }
        public bool EsAdmin { get { return esAdmin; } }
        public int Dni { get { return dni; } }
        public int Id { get { return id; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Id: {Id}");
            sb.AppendLine($" Nombre: {Nombre} DNI: {Dni}");
            if (EsAdmin == true)
            {
                sb.AppendLine($"Cargo: Administrador");
            }
            else { sb.AppendLine("Cargo: Empleado"); }

            return sb.ToString();
        }

        public Persona FindById(List<Persona> listaUsuarios, Persona p1)
        {
            foreach (Persona item in listaUsuarios)
            {
                if(item==p1)
                {
                    return item;
                }
            }
            return null;
        }

        public static bool operator ==(Persona p1, Persona p2)
        {
            if (p1 is not null && p2 is not null)
            {
                if (p1.id==p2.id)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(List<Persona> p1, Persona p2)
        {
            if (p1 is not null && p2 is not null)
            {
                if (p1.Contains(p2))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(List<Persona> p1, Persona p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Persona p1, int id)
        {
            if (p1 is not null && id >0)
            {
                if (p1.id == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Persona p1, int id)
        {
            return !(p1 == id);
        }

    }
}
