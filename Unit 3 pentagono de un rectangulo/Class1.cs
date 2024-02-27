using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public abstract class Figura
    {
        protected double area; // Área de la figura

        public abstract void CalcularArea();
        public virtual void MostrarDatos()
        {
            Console.WriteLine("Área: {0}", area);
        }
    }

    // Clase que representa un pentágono regular
    public class Pentagono : Figura
    {
        // Atributo propio del pentágono
        private double lado; // Lado del pentágono

        // Constructor con parámetro
        public Pentagono(double lado)
        {
            this.lado = lado;
            CalcularArea(); // Se calcula el área al crear el objeto
        }

        // Sobrecarga del constructor
        public Pentagono(double lado, double area)
        {
            this.lado = lado;
            this.area = area;
        }

        // Destructor
        ~Pentagono()
        {
            Console.WriteLine("El objeto Pentagono ha sido destruido");
        }

        // Getter y setter
        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        // Otros métodos
        // Método que calcula el área del pentágono
        public override void CalcularArea()
        {
            // Fórmula: $$A = \frac{5l^2}{4\tan(\frac{\pi}{5})}$$
            area = (5 * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / 5));
        }

        // Método que muestra la información del pentágono
        public override void MostrarDatos()
        {
            Console.WriteLine("Pentágono");
            Console.WriteLine("Lado: {0}", lado);
            base.MostrarDatos(); // Se llama al método de la clase base
        }
    }
}

