using Colas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_TP05
{
    public partial class Form1 : Form
    {
        Vector v;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v = new Vector(double.Parse(llegadaA.Text.ToString()), double.Parse(llegadaB.Text.ToString()),
                    double.Parse(atSurtidorA.Text.ToString()), double.Parse(atSurtidorB.Text.ToString()),
                    double.Parse(atGomA.Text.ToString()), double.Parse(atGomB.Text.ToString()),
                    double.Parse(atAccA.Text.ToString()), double.Parse(atAccB.Text.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            v.Clear(double.Parse(llegadaA.Text.ToString()), double.Parse(llegadaB.Text.ToString()),
                    double.Parse(atSurtidorA.Text.ToString()), double.Parse(atSurtidorB.Text.ToString()),
                    double.Parse(atGomA.Text.ToString()), double.Parse(atGomB.Text.ToString()),
                    double.Parse(atAccA.Text.ToString()), double.Parse(atAccB.Text.ToString()));
            dataGridView1.ColumnCount = 36;
            dataGridView1.Columns[0].HeaderCell.Value = "Evento";
            dataGridView1.Columns[1].HeaderCell.Value = "Reloj";
            dataGridView1.Columns[2].HeaderCell.Value = "Tiempo";
            dataGridView1.Columns[3].HeaderCell.Value = "Prox. Llegada";
            dataGridView1.Columns[4].HeaderCell.Value = "S1. Estado";
            dataGridView1.Columns[5].HeaderCell.Value = "S1. Cola";
            dataGridView1.Columns[6].HeaderCell.Value = "S1. Tiempo";
            dataGridView1.Columns[7].HeaderCell.Value = "S1. Fin atencion";
            dataGridView1.Columns[8].HeaderCell.Value = "S2. Estado";
            dataGridView1.Columns[9].HeaderCell.Value = "S2. Cola";
            dataGridView1.Columns[10].HeaderCell.Value = "S2. Tiempo";
            dataGridView1.Columns[11].HeaderCell.Value = "S2. Fin atencion";
            dataGridView1.Columns[12].HeaderCell.Value = "S3. Estado";
            dataGridView1.Columns[13].HeaderCell.Value = "S3. Cola";
            dataGridView1.Columns[14].HeaderCell.Value = "S3. Tiempo";
            dataGridView1.Columns[15].HeaderCell.Value = "S3. Fin atencion";
            dataGridView1.Columns[16].HeaderCell.Value = "EG1. Estado";
            dataGridView1.Columns[17].HeaderCell.Value = "EG1. Cola";
            dataGridView1.Columns[18].HeaderCell.Value = "EG1. Tiempo";
            dataGridView1.Columns[19].HeaderCell.Value = "EG1. Fin atencion";
            dataGridView1.Columns[20].HeaderCell.Value = "EG2. Estado";
            dataGridView1.Columns[21].HeaderCell.Value = "EG2. Cola";
            dataGridView1.Columns[22].HeaderCell.Value = "EG2. Tiempo";
            dataGridView1.Columns[23].HeaderCell.Value = "EG2. Fin atencion";
            dataGridView1.Columns[24].HeaderCell.Value = "EA1. Estado";
            dataGridView1.Columns[25].HeaderCell.Value = "EA1. Cola";
            dataGridView1.Columns[26].HeaderCell.Value = "EA1. Tiempo";
            dataGridView1.Columns[27].HeaderCell.Value = "EA1. Fin atencion";
            dataGridView1.Columns[28].HeaderCell.Value = "Autos Carga";
            dataGridView1.Columns[29].HeaderCell.Value = "Autos S/C";
            dataGridView1.Columns[30].HeaderCell.Value = "Oc. S1";
            dataGridView1.Columns[31].HeaderCell.Value = "Oc. S2";
            dataGridView1.Columns[32].HeaderCell.Value = "Oc. S3";
            dataGridView1.Columns[33].HeaderCell.Value = "Oc. G1";
            dataGridView1.Columns[34].HeaderCell.Value = "Oc. G2";
            dataGridView1.Columns[35].HeaderCell.Value = "Oc. A1";

            for (int i = 0; i < int.Parse(textBox3.Text); i++)
            {
                if (i <= int.Parse(textBox2.Text) && i >= int.Parse(textBox1.Text))
                {
                    dataGridView1.Rows.Add(v.GetRow());
                };
                v.EjecutarSiguiente();
            }
            v.UpdateTiempoAtencionRestante();
            SetEstadisticas();


        }

        public void SetEstadisticas()
        {
            sc.Text = String.Format("{0:0.00} %", ((decimal)v.autosSoloCarga / (decimal)v.autosCarga) * (decimal)100);
            aaS1.Text = String.Format("{0:0.00} %", ((decimal)v.tiempoAtencionAcumuladoS1 / (decimal)v.reloj) * (decimal)100);
            aaS2.Text = String.Format("{0:0.00} %", ((decimal)v.tiempoAtencionAcumuladoS2 / (decimal)v.reloj) * (decimal)100);
            aaS3.Text = String.Format("{0:0.00} %", ((decimal)v.tiempoAtencionAcumuladoS3 / (decimal)v.reloj) * (decimal)100);
            aaG1.Text = String.Format("{0:0.00} %", ((decimal)v.tiempoAtencionAcumuladoG1 / (decimal)v.reloj) * (decimal)100);
            aaG2.Text = String.Format("{0:0.00} %", ((decimal)v.tiempoAtencionAcumuladoG2 / (decimal)v.reloj) * (decimal)100);
            aaA1.Text = String.Format("{0:0.00} %", ((decimal)v.tiempoAtencionAcumuladoA1 / (decimal)v.reloj) * (decimal)100);
        }
    }
}
