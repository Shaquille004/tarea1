using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tarea1;
    class class1
    {
        static void Main(string[]args)
        {
        Estudiantes estudiantes = new Estudiantes
        {
            Nombre = "Shaquille",
            Apellido = "Mercado ",
            edad = 19,
            matricula = "2022-1029",
            Ingreso = new DateTime(2022, 05, 11),
            carrera = "Desarrollo Software"
        };

        estudiantes.Guardar(estudiantes);
            estudiantes.obtener(estudiantes);


            empleados empleado = new empleados();
            empleado.Nombre = "Sharelyn";
            empleado.Apellido = "Marcelino";
            empleado.edad = 21;
            empleado.experiencia = 1;
            empleado.Cargo = "publicista";
            empleado.sueldo = 50000.00;


            empleado.Guardar(empleado);
            empleado.obtener(empleado);

            Maestro maestro = new Maestro();
            maestro.Instituto = new List<string>();
            maestro.Instituto.Add("Santa Maria");

            maestro.Guardar(maestro);
            maestro.obtener(maestro);

            administrador Admin = new administrador();
            Admin.proyectos = new List<string>();

            Admin.proyectos.Add("Desarrollo de programas academicos");

            Admin.Guardar(Admin);
            Admin.obtener(Admin);




        }
    }

