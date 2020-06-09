using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;

namespace Colas
{

    public class Vector
    {
        public string evento { get; set; }
        public float reloj { get; set; }
        public double llegadaA { get; set; }
        public double llegadaB { get; set; }
        public double atSurtidorA { get; set; }
        public double atSurtidorB { get; set; }
        public double atGomA { get; set; }
        public double atGomB { get; set; }
        public double atAccA { get; set; }
        public double atAccB { get; set; }
        public float tiempoEntreLlegada { get; set; }
        public float proximaLlegada { get; set; }
        public Surtidor surtidor1 { get; set; }
        public Surtidor surtidor2 { get; set; }
        public Surtidor surtidor3 { get; set; }
        public Empleado empleadoGomeria1 { get; set; }
        public Empleado empleadoGomeria2 { get; set; }
        public Empleado empleadoAcc1 { get; set; }


        public int autosSoloCarga { get; set; }
        public float tiempoAtencionAcumuladoS1 { get; set; }
        public float tiempoAtencionAcumuladoS2 { get; set; }
        public float tiempoAtencionAcumuladoS3 { get; set; }
        public float tiempoAtencionAcumuladoG1 { get; set; }
        public float tiempoAtencionAcumuladoG2 { get; set; }
        public float tiempoAtencionAcumuladoA1 { get; set; }
        public int autosCarga { get; set; }
        public int autosGomeria { get; set; }
        public int autosAcc { get; set; }

        public Vector(double llegadaA, double llegadaB, double atSurtidorA, double atSurtidorB, double atGomA, double atGomB, double atAccA, double atAccB)
        {
            this.evento = "Est. inicial";
            this.llegadaA = llegadaA;
            this.llegadaB = llegadaB;
            this.atSurtidorA = atSurtidorA;
            this.atSurtidorB = atSurtidorB;
            this.atGomA = atGomA;
            this.atGomB = atGomB;
            this.atAccA = atAccA;
            this.atAccB = atAccB;
            this.reloj = (float)0.00;
            this.tiempoEntreLlegada = (float)ContinuousUniform.Sample(this.llegadaA, this.llegadaB) / 100;
            this.proximaLlegada = this.reloj + this.tiempoEntreLlegada;
            this.surtidor1 = new Surtidor();
            this.surtidor2 = new Surtidor();
            this.surtidor3 = new Surtidor();
            this.empleadoGomeria1 = new Empleado();
            this.empleadoGomeria2 = new Empleado();
            this.empleadoAcc1 = new Empleado();
            this.autosAcc = 0;
            this.autosCarga = 0;
            this.autosGomeria = 0;
        }

        public string[] GetRow()
        {
            return new string[] { this.evento, this.reloj.ToString("0.00"), this.tiempoEntreLlegada.ToString("0.00"),
                this.proximaLlegada.ToString("0.00"),
            this.surtidor1.estado, this.surtidor1.cola.ToString(),
                this.surtidor1.tiempoAtencion.ToString("0.00"), this.surtidor1.finAtencion.ToString("0.00"),
            this.surtidor2.estado, this.surtidor2.cola.ToString(),
                this.surtidor2.tiempoAtencion.ToString("0.00"), this.surtidor2.finAtencion.ToString("0.00"),
            this.surtidor3.estado, this.surtidor3.cola.ToString(),
                this.surtidor3.tiempoAtencion.ToString("0.00"), this.surtidor3.finAtencion.ToString("0.00"),
            this.empleadoGomeria1.estado, this.empleadoGomeria1.cola.ToString(),
                this.empleadoGomeria1.tiempoAtencion.ToString("0.00"), this.empleadoGomeria1.finAtencion.ToString("0.00"),
            this.empleadoGomeria2.estado, this.empleadoGomeria2.cola.ToString(),
                this.empleadoGomeria2.tiempoAtencion.ToString("0.00"), this.empleadoGomeria2.finAtencion.ToString("0.00"),
            this.empleadoAcc1.estado, this.empleadoAcc1.cola.ToString(),
                this.empleadoAcc1.tiempoAtencion.ToString("0.00"), this.empleadoAcc1.finAtencion.ToString("0.00"),
            this.autosCarga.ToString(), this.autosSoloCarga.ToString(),
            this.tiempoAtencionAcumuladoS1.ToString("0.00"), this.tiempoAtencionAcumuladoS3.ToString("0.00"), this.tiempoAtencionAcumuladoS2.ToString("0.00"),
            this.tiempoAtencionAcumuladoG1.ToString("0.00"), this.tiempoAtencionAcumuladoG2.ToString("0.00"), this.tiempoAtencionAcumuladoA1.ToString("0.00")};
        }

        public void Clear(double llegadaA, double llegadaB, double atSurtidorA, double atSurtidorB, double atGomA, double atGomB, double atAccA, double atAccB)
        {
            this.evento = "Est. inicial";
            this.llegadaA = llegadaA;
            this.llegadaB = llegadaB;
            this.atSurtidorA = atSurtidorA;
            this.atSurtidorB = atSurtidorB;
            this.atGomA = atGomA;
            this.atGomB = atGomB;
            this.atAccA = atAccA;
            this.atAccB = atAccB;
            this.reloj = (float)0.00;
            this.tiempoEntreLlegada = (float)ContinuousUniform.Sample(this.llegadaA, this.llegadaB) / 100;
            this.proximaLlegada = this.reloj + this.tiempoEntreLlegada;
            this.surtidor1 = new Surtidor();
            this.surtidor2 = new Surtidor();
            this.surtidor3 = new Surtidor();
            this.empleadoGomeria1 = new Empleado();
            this.empleadoGomeria2 = new Empleado();
            this.empleadoAcc1 = new Empleado();
            this.autosSoloCarga = 0;
            this.tiempoAtencionAcumuladoS1 = 0;
            this.tiempoAtencionAcumuladoS2 = 0;
            this.tiempoAtencionAcumuladoS3 = 0;
            this.tiempoAtencionAcumuladoG1 = 0;
            this.tiempoAtencionAcumuladoG2 = 0;
            this.tiempoAtencionAcumuladoA1 = 0;
            this.autosAcc = 0;
            this.autosCarga = 0;
            this.autosGomeria = 0;
        }
        public Dictionary<string, Object> SiguienteEvento()
        {
            Dictionary<string, Object> menor = new Dictionary<string, Object>();
            menor.Add("evento", "Llegada cliente");
            menor.Add("tiempo", this.proximaLlegada);
            if (this.surtidor1.finAtencion != 0 && (float)menor["tiempo"] > this.surtidor1.finAtencion)
            {
                menor["evento"] = "Fin atencion surtidor 1";
                menor["tiempo"] = this.surtidor1.finAtencion;
            }
            else if (this.surtidor2.finAtencion != 0 && (float)menor["tiempo"] > this.surtidor2.finAtencion)
            {
                menor["evento"] = "Fin atencion surtidor 2";
                menor["tiempo"] = this.surtidor2.finAtencion;
            }
            else if (this.surtidor3.finAtencion != 0 && (float)menor["tiempo"] > this.surtidor3.finAtencion)
            {
                menor["evento"] = "Fin atencion surtidor 3";
                menor["tiempo"] = this.surtidor3.finAtencion;
            }
            else if (this.empleadoGomeria1.finAtencion != 0 && (float)menor["tiempo"] > this.empleadoGomeria1.finAtencion)
            {
                menor["evento"] = "Fin atencion gomeria 1";
                menor["tiempo"] = this.empleadoGomeria1.finAtencion;
            }
            else if (this.empleadoGomeria2.finAtencion != 0 && (float)menor["tiempo"] > this.empleadoGomeria2.finAtencion)
            {
                menor["evento"] = "Fin atencion gomeria 2";
                menor["tiempo"] = this.empleadoGomeria2.finAtencion;
            }
            else if (this.empleadoAcc1.finAtencion != 0 && (float)menor["tiempo"] > this.empleadoAcc1.finAtencion)
            {
                menor["evento"] = "Fin atencion acc 1";
                menor["tiempo"] = this.empleadoAcc1.finAtencion;
            }
            return menor;
        }

        public void EjecutarSiguiente()
        {
            Dictionary<string, Object> menor = this.SiguienteEvento();
            switch (menor["evento"])
            {
                case "Llegada cliente":
                    this.evento = "Llegada cliente";
                    this.reloj = (float)menor["tiempo"];
                    this.tiempoEntreLlegada = (float)ContinuousUniform.Sample(this.llegadaA, this.llegadaB) / 100;
                    this.proximaLlegada = this.reloj + this.tiempoEntreLlegada;
                    if (DeterminarSiCarga((float)ContinuousUniform.Sample(0, 1)))
                    {
                        this.AsignarSurtidor();
                    }
                    else
                    {
                        string servicio = DeterminarServicioSiNoCarga((float)ContinuousUniform.Sample(0, 1));
                        if (servicio == "Gomeria")
                        {
                            AsignarEmpleadoGomeria();

                        }
                        else
                        {
                            AsignarEmpleadoAcc();
                        }
                    }
                    break;
                case "Fin atencion surtidor 1":
                    this.evento = "Fin atencion surtidor 1";
                    this.reloj = (float)menor["tiempo"];
                    this.tiempoAtencionAcumuladoS1 += this.surtidor1.tiempoAtencion;

                    this.surtidor1.Liberar(reloj, atSurtidorA / 100, atSurtidorB / 100);
                    break;
                case "Fin atencion surtidor 2":
                    this.evento = "Fin atencion surtidor 2";
                    this.reloj = (float)menor["tiempo"];
                    this.tiempoAtencionAcumuladoS2 += this.surtidor2.tiempoAtencion;

                    this.surtidor2.Liberar(reloj, atSurtidorA / 100, atSurtidorB / 100);
                    break;
                case "Fin atencion surtidor 3":
                    this.evento = "Fin atencion surtidor 3";
                    this.reloj = (float)menor["tiempo"];
                    this.tiempoAtencionAcumuladoS3 += this.surtidor3.tiempoAtencion;

                    this.surtidor3.Liberar(reloj, atSurtidorA / 100, atSurtidorB / 100);
                    break;
                case "Fin atencion gomeria 1":
                    this.evento = "Fin atencion gomeria 1";
                    this.reloj = (float)menor["tiempo"];
                    this.tiempoAtencionAcumuladoG1 += this.empleadoGomeria1.tiempoAtencion;

                    this.empleadoGomeria1.Liberar(reloj, atGomA, atGomB);
                    break;
                case "Fin atencion gomeria 2":
                    this.evento = "Fin atencion gomeria 2";
                    this.reloj = (float)menor["tiempo"];
                    this.tiempoAtencionAcumuladoG2 += this.empleadoGomeria2.tiempoAtencion;

                    this.empleadoGomeria2.Liberar(reloj, atGomA, atGomB);
                    break;
                case "Fin atencion acc 1":
                    this.evento = "Fin atencion acc 1";
                    this.reloj = (float)menor["tiempo"];
                    this.tiempoAtencionAcumuladoA1 += this.empleadoAcc1.tiempoAtencion;

                    this.empleadoAcc1.Liberar(reloj, atAccA, atAccB);
                    break;
                default:
                    break;
            }
            if (menor["evento"].ToString().Contains("surtidor"))
            {
                this.AsignarServicioSiCorresponde((float)ContinuousUniform.Sample(0, 1));
            }
        }

        public void AsignarSurtidor()
        {
            if (this.surtidor1.estado == "Libre")
            {
                this.surtidor1.Ocupar(this.reloj);
                this.surtidor1.tiempoAtencion = (float)ContinuousUniform.Sample(this.atSurtidorA, this.atSurtidorB) / 100;
                this.surtidor1.finAtencion = this.reloj + this.surtidor1.tiempoAtencion;
            }
            else if (this.surtidor2.estado == "Libre")
            {
                this.surtidor2.Ocupar(this.reloj);
                this.surtidor2.tiempoAtencion = (float)ContinuousUniform.Sample(this.atSurtidorA, this.atSurtidorB) / 100;
                this.surtidor2.finAtencion = this.reloj + this.surtidor2.tiempoAtencion;
            }
            else if (this.surtidor3.estado == "Libre")
            {
                this.surtidor3.Ocupar(this.reloj);
                this.surtidor3.tiempoAtencion = (float)ContinuousUniform.Sample(this.atSurtidorA, this.atSurtidorB) / 100;
                this.surtidor3.finAtencion = this.reloj + this.surtidor3.tiempoAtencion;
            }
            else
            {
                Surtidor menor = DeterminarMenosOcupado();
                menor.Ocupar(this.reloj);
            }
            this.autosCarga++;
        }

        public void AsignarEmpleadoGomeria()
        {
            if (this.empleadoGomeria1.estado == "Libre")
            {
                this.empleadoGomeria1.Ocupar(this.reloj);
                this.empleadoGomeria1.tiempoAtencion = (float)ContinuousUniform.Sample(this.atGomA, this.atGomB);
                this.empleadoGomeria1.finAtencion = this.reloj + this.empleadoGomeria1.tiempoAtencion;
            }
            else if (this.empleadoGomeria2.estado == "Libre")
            {
                this.empleadoGomeria2.Ocupar(this.reloj);
                this.empleadoGomeria2.tiempoAtencion = (float)ContinuousUniform.Sample(this.atGomA, this.atGomB);
                this.empleadoGomeria2.finAtencion = this.reloj + this.empleadoGomeria2.tiempoAtencion;
            }
            else
            {
                Empleado menor = DeterminarEmpleadoMenosOcupado();
                menor.Ocupar(this.reloj);
            }
            this.autosGomeria++;
        }

        public void AsignarEmpleadoAcc()
        {
            if (this.empleadoAcc1.estado == "Libre")
            {
                this.empleadoAcc1.Ocupar(this.reloj);
                this.empleadoAcc1.tiempoAtencion = (float)ContinuousUniform.Sample(this.atAccA, this.atAccB);
                this.empleadoAcc1.finAtencion = this.reloj + this.empleadoAcc1.tiempoAtencion;
            }
            else
            {
                this.empleadoAcc1.Ocupar(this.reloj);
            }
            this.autosAcc++;
        }

        public void AsignarServicioSiCorresponde(float random)
        {
            if (random <= (float)0.30)
            {
                AsignarEmpleadoAcc();
            }
            else if (random <= (float)0.50)
            {
                AsignarEmpleadoGomeria();
            }
            else
            {
                this.autosSoloCarga++;
            }
        }

        public Surtidor DeterminarMenosOcupado()
        {
            Surtidor menor = this.surtidor1;
            if (this.surtidor2.cola <= menor.cola)
            {
                menor = this.surtidor2;
            }
            else if (this.surtidor3.cola <= menor.cola)
            {
                menor = this.surtidor3;
            }
            return menor;
        }

        public Empleado DeterminarEmpleadoMenosOcupado()
        {
            Empleado menor = this.empleadoGomeria1;
            if (this.empleadoGomeria2.cola <= menor.cola)
            {
                menor = this.empleadoGomeria2;
            }
            return menor;
        }

        public bool DeterminarSiCarga(float random)
        {
            return (random <= (float)0.80);
        }

        public string DeterminarServicioSiNoCarga(float random)
        {
            if (random <= (float)0.40)
            {
                return "Accesorios";
            }
            return "Gomeria";
        }

        public void UpdateTiempoAtencionRestante()
        {
            if (this.surtidor1.estado == "Ocupado")
            {
                this.tiempoAtencionAcumuladoS1 += (this.reloj - this.surtidor1.inicioAtencion);
            }
            if (this.surtidor2.estado == "Ocupado")
            {
                this.tiempoAtencionAcumuladoS2 += (this.reloj - this.surtidor2.inicioAtencion);
            }
            if (this.surtidor3.estado == "Ocupado")
            {
                this.tiempoAtencionAcumuladoS3 += (this.reloj - this.surtidor3.inicioAtencion);
            }
            if (this.empleadoGomeria1.estado == "Ocupado")
            {
                this.tiempoAtencionAcumuladoG1 += (this.reloj - this.empleadoGomeria1.inicioAtencion);
            }
            if (this.empleadoGomeria2.estado == "Ocupado")
            {
                this.tiempoAtencionAcumuladoG2 += (this.reloj - this.empleadoGomeria2.inicioAtencion);
            }
            if (this.empleadoAcc1.estado == "Ocupado")
            {
                this.tiempoAtencionAcumuladoA1 += (this.reloj - this.empleadoAcc1.inicioAtencion);
            }
        }
    }

    public class Servidor
    {
        public string estado { get; set; }
        public int cola { get; set; }
        public float inicioAtencion { get; set; }
        public float tiempoAtencion { get; set; }
        public float finAtencion { get; set; }
        public string cliente { get; set; }

        public Servidor()
        {
            this.estado = "Libre";
            this.cola = 0;
        }

        public void Ocupar(float reloj)
        {
            if (this.estado == "Ocupado")
            {
                this.cola += 1;
            }
            else
            {
                this.estado = "Ocupado";
                this.inicioAtencion = reloj;
            }
        }

        public void Liberar(float reloj, double tiempoAtencionA, double tiempoAtencionB)
        {
            if (this.cola > 0)
            {
                this.cola--;
                this.inicioAtencion = reloj;
                this.tiempoAtencion = (float)ContinuousUniform.Sample(tiempoAtencionA, tiempoAtencionB);
                this.finAtencion = reloj + this.tiempoAtencion;
            }
            else
            {
                this.estado = "Libre";
                this.inicioAtencion = 0;
                this.tiempoAtencion = 0;
                this.finAtencion = 0;
            }

        }
    }

    public class Empleado : Servidor
    {

    };

    public class Surtidor : Servidor
    {

    };

    public class Cliente
    {
        public int id { get; set; }
        public string estado { get; set; }
        public float horaLlegada { get; set; }
        public string surtidorAsignado { get; set; }
        public string empleadoAsignado { get; set; }

        public Cliente(string estado, int id, float horaLlegada, string surtidor, string empleado)
        {
            this.estado = estado;
            this.id = id;
            this.horaLlegada = horaLlegada;
            this.surtidorAsignado = surtidor;
            this.empleadoAsignado = empleado;
        }
    }
}

