﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{

    public partial class FrmHorarios : Form
    {
        public string usuario;
        public string banca;
        public string acceso;

        public FrmHorarios()
        {
            InitializeComponent();
        }

        private void cbLoteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        if (cbLoteria.Text != string.Empty && cbLoteria.Text == "GanaMas")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "GM").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Real")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "RL").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Quiniela Pale")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "QP").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "La Primera")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "LP").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "New York")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "NT").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "New York Noche")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "NN").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Florida")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "FT").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Florida Noche")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "FN").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Nacional")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "NA").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Loteka")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "LK").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "La Suerte")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "LS").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "King Tarde")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "KT").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "King Noche")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "KN").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Anguila 10 AM")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "AD").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Anguila 1 PM")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "AU").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Anguila 5 PM")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "AC").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Anguila 9 PM")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "AN").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        if (cbLoteria.Text != string.Empty && cbLoteria.Text == "GanaMas")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "GM").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Real")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "RL").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Quiniela Pale")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "QP").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "La Primera")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "LP").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "New York")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "NT").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "New York Noche")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "NN").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Florida")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "FT").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Florida Noche")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "FN").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Nacional")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "NA").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Loteka")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "LK").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "La Suerte")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "LS").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "King Tarde")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "KT").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "King Noche")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "KN").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Anguila 10 AM")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "AD").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Anguila 1 PM")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "AU").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Anguila 5 PM")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "AC").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                        else if (cbLoteria.Text != string.Empty && cbLoteria.Text == "Anguila 9 PM")
                        {
                            var consulta = context.Horarios.Where(x => x.Loteria == "AN").FirstOrDefault();
                            if (consulta != null)
                            {
                                this.cbHora.Text = consulta.Hora.ToString();
                                this.cbMinutos.Text = consulta.Minutos.ToString();
                                this.cbEstatusHorario.Text = consulta.Estatus;
                                this.cbTanda.Text = consulta.Tanda;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnActualizarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                if (acceso == "Administrador")
                {
                    using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                    {
                        if (cbLoteria.Text != "Seleccione Lotería" && cbLoteria.Text != string.Empty)
                        {
                            string loteria = "";

                            if (cbLoteria.Text == "GanaMas")
                            {
                                loteria = "GM";
                            }
                            else if (cbLoteria.Text == "Real")
                            {
                                loteria = "RL";
                            }
                            else if (cbLoteria.Text == "Quiniela Pale")
                            {
                                loteria = "QP";
                            }
                            else if (cbLoteria.Text == "La Suerte")
                            {
                                loteria = "LS";
                            }
                            else if (cbLoteria.Text == "Real")
                            {
                                loteria = "RL";
                            }
                            else if (cbLoteria.Text == "La Primera")
                            {
                                loteria = "LP";
                            }
                            else if (cbLoteria.Text == "New York")
                            {
                                loteria = "NT";
                            }
                            else if (cbLoteria.Text == "New York Noche")
                            {
                                loteria = "NN";
                            }
                            else if (cbLoteria.Text == "Florida")
                            {
                                loteria = "FT";
                            }
                            else if (cbLoteria.Text == "Florida Noche")
                            {
                                loteria = "FN";
                            }
                            else if (cbLoteria.Text == "Nacional")
                            {
                                loteria = "NA";
                            }
                            else if (cbLoteria.Text == "Loteka")
                            {
                                loteria = "LK";
                            }
                            else if (cbLoteria.Text == "King Tarde")
                            {
                                loteria = "KT";
                            }
                            else if (cbLoteria.Text == "King Noche")
                            {
                                loteria = "KN";
                            }
                            else if (cbLoteria.Text == "Anguila 10 AM")
                            {
                                loteria = "AD";
                            }
                            else if (cbLoteria.Text == "Anguila 1 PM")
                            {
                                loteria = "AU";
                            }
                            else if (cbLoteria.Text == "Anguila 5 PM")
                            {
                                loteria = "AC";
                            }
                            else if (cbLoteria.Text == "Anguila 9 PM")
                            {
                                loteria = "AN";
                            }

                            var consulta = context.Horarios.Where(x => x.Loteria == loteria).FirstOrDefault();

                            if (consulta != null)
                            {
                                consulta.Loteria = loteria;
                                consulta.Hora = Convert.ToInt32(cbHora.Text);
                                consulta.Minutos = Convert.ToInt32(cbMinutos.Text);
                                consulta.Estatus = cbEstatusHorario.Text;
                                consulta.Fecha = DateTime.Now;
                                consulta.Tanda = cbTanda.Text;

                                context.SaveChanges();
                                mensajeOk("Registro Actualizado servidor");
                                Mostrar();
                            }
                            else
                            {
                                CapaDatos.Modelo.Horarios _horario = new CapaDatos.Modelo.Horarios();

                                _horario.Loteria = loteria;
                                _horario.Hora = Convert.ToInt32(cbHora.Text);
                                _horario.Minutos = Convert.ToInt32(cbMinutos.Text);
                                _horario.Estatus = cbEstatusHorario.Text;
                                _horario.Fecha = DateTime.Now;
                                _horario.Tanda = cbTanda.Text;

                                context.Horarios.Add(_horario);
                                context.SaveChanges();
                                mensajeOk("Registro Creado servidor");
                                Mostrar();
                            }


                        }

                    }

                    try
                    {
                        using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                        {
                            if (cbLoteria.Text != "Seleccione Lotería" && cbLoteria.Text != string.Empty)
                            {
                                string loteria = "";

                                if (cbLoteria.Text == "GanaMas")
                                {
                                    loteria = "GM";
                                }
                                else if (cbLoteria.Text == "Real")
                                {
                                    loteria = "RL";
                                }
                                else if (cbLoteria.Text == "Quiniela Pale")
                                {
                                    loteria = "QP";
                                }
                                else if (cbLoteria.Text == "La Suerte")
                                {
                                    loteria = "LS";
                                }
                                else if (cbLoteria.Text == "Real")
                                {
                                    loteria = "RL";
                                }
                                else if (cbLoteria.Text == "La Primera")
                                {
                                    loteria = "LP";
                                }
                                else if (cbLoteria.Text == "New York")
                                {
                                    loteria = "NT";
                                }
                                else if (cbLoteria.Text == "New York Noche")
                                {
                                    loteria = "NN";
                                }
                                else if (cbLoteria.Text == "Florida")
                                {
                                    loteria = "FT";
                                }
                                else if (cbLoteria.Text == "Florida Noche")
                                {
                                    loteria = "FN";
                                }
                                else if (cbLoteria.Text == "Nacional")
                                {
                                    loteria = "NA";
                                }
                                else if (cbLoteria.Text == "Loteka")
                                {
                                    loteria = "LK";
                                }
                                else if (cbLoteria.Text == "King Tarde")
                                {
                                    loteria = "KT";
                                }
                                else if (cbLoteria.Text == "King Noche")
                                {
                                    loteria = "KN";
                                }
                                else if (cbLoteria.Text == "Anguila 10 AM")
                                {
                                    loteria = "AD";
                                }
                                else if (cbLoteria.Text == "Anguila 1 PM")
                                {
                                    loteria = "AU";
                                }
                                else if (cbLoteria.Text == "Anguila 5 PM")
                                {
                                    loteria = "AC";
                                }
                                else if (cbLoteria.Text == "Anguila 9 PM")
                                {
                                    loteria = "AN";
                                }

                                var consulta = context.Horarios.Where(x => x.Loteria == loteria).FirstOrDefault();

                                if (consulta != null)
                                {
                                    consulta.Hora = Convert.ToInt32(cbHora.Text);
                                    consulta.Minutos = Convert.ToInt32(cbMinutos.Text);
                                    consulta.Estatus = cbEstatusHorario.Text;
                                    consulta.Fecha = DateTime.Now;
                                    consulta.Tanda = cbTanda.Text;

                                    context.SaveChanges();
                                    mensajeOk("Registro Actualizado Local");

                                    Mostrar();
                                }
                                else
                                {
                                    CapaDatos.ModeloLocal.Horarios _horario = new CapaDatos.ModeloLocal.Horarios();

                                    _horario.Loteria = loteria;
                                    _horario.Hora = Convert.ToInt32(cbHora.Text);
                                    _horario.Minutos = Convert.ToInt32(cbMinutos.Text);
                                    _horario.Estatus = cbEstatusHorario.Text;
                                    _horario.Fecha = DateTime.Now;
                                    _horario.Tanda = cbTanda.Text;

                                    context.Horarios.Add(_horario);
                                    context.SaveChanges();
                                    mensajeOk("Registro Creado Local");
                                    Mostrar();
                                }


                            }

                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        if (cbLoteria.Text != "Seleccione Lotería" && cbLoteria.Text != string.Empty)
                        {
                            string loteria = "";

                            if (cbLoteria.Text == "GanaMas")
                            {
                                loteria = "GM";
                            }
                            else if (cbLoteria.Text == "Real")
                            {
                                loteria = "RL";
                            }
                            else if (cbLoteria.Text == "Quiniela Pale")
                            {
                                loteria = "QP";
                            }
                            else if (cbLoteria.Text == "La Suerte")
                            {
                                loteria = "LS";
                            }
                            else if (cbLoteria.Text == "Real")
                            {
                                loteria = "RL";
                            }
                            else if (cbLoteria.Text == "La Primera")
                            {
                                loteria = "LP";
                            }
                            else if (cbLoteria.Text == "New York")
                            {
                                loteria = "NT";
                            }
                            else if (cbLoteria.Text == "New York Noche")
                            {
                                loteria = "NN";
                            }
                            else if (cbLoteria.Text == "Florida")
                            {
                                loteria = "FT";
                            }
                            else if (cbLoteria.Text == "Florida Noche")
                            {
                                loteria = "FN";
                            }
                            else if (cbLoteria.Text == "Nacional")
                            {
                                loteria = "NA";
                            }
                            else if (cbLoteria.Text == "Loteka")
                            {
                                loteria = "LK";
                            }
                            else if (cbLoteria.Text == "King Tarde")
                            {
                                loteria = "KT";
                            }
                            else if (cbLoteria.Text == "King Noche")
                            {
                                loteria = "KN";
                            }
                            else if (cbLoteria.Text == "Anguila 10 AM")
                            {
                                loteria = "AD";
                            }
                            else if (cbLoteria.Text == "Anguila 1 PM")
                            {
                                loteria = "AU";
                            }
                            else if (cbLoteria.Text == "Anguila 5 PM")
                            {
                                loteria = "AC";
                            }
                            else if (cbLoteria.Text == "Anguila 9 PM")
                            {
                                loteria = "AN";
                            }

                            var consulta = context.Horarios.Where(x => x.Loteria == loteria).FirstOrDefault();

                            if (consulta != null)
                            {
                                consulta.Hora = Convert.ToInt32(cbHora.Text);
                                consulta.Minutos = Convert.ToInt32(cbMinutos.Text);
                                consulta.Estatus = cbEstatusHorario.Text;
                                consulta.Fecha = DateTime.Now;
                                consulta.Tanda = cbTanda.Text;

                                context.SaveChanges();
                                mensajeOk("Registro Actualizado Local");

                                Mostrar();
                            }
                            else
                            {
                                CapaDatos.ModeloLocal.Horarios _horario = new CapaDatos.ModeloLocal.Horarios();

                                _horario.Loteria = loteria;
                                _horario.Hora = Convert.ToInt32(cbHora.Text);
                                _horario.Minutos = Convert.ToInt32(cbMinutos.Text);
                                _horario.Estatus = cbEstatusHorario.Text;
                                _horario.Fecha = DateTime.Now;
                                _horario.Tanda = cbTanda.Text;

                                context.Horarios.Add(_horario);
                                context.SaveChanges();
                                mensajeOk("Registro Creado Local");
                                Mostrar();
                            }


                        }

                    }
                }
                Mostrar();
            }
            catch (Exception)
            {

            }
        }

        private void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SOL20", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmHorarios_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 10;
            Mostrar();
        }

        private void Ocultar_Columnas()
        {
            this.dtgListado.Columns[0].Visible = false;
        }

        private void Mostrar()
        {
            try
            {
                if (acceso == "Administrador")
                {
                using (CapaDatos.Modelo.ModelDB context = new CapaDatos.Modelo.ModelDB())
                {
                    var consulta = context.Horarios.ToList();
                    dtgListado.DataSource = consulta;
                }
            }
                else
                {
                    using (CapaDatos.ModeloLocal.Modelo_Local context = new CapaDatos.ModeloLocal.Modelo_Local())
                    {
                        var consulta = context.Horarios.ToList();
                        dtgListado.DataSource = consulta;
                        Ocultar_Columnas();
                        cbLoteria.Text = "Seleccione Lotería";
                        cbHora.Text = string.Empty;
                        cbMinutos.Text = string.Empty;
                        cbEstatusHorario.Text = "Seleccione";
                        cbTanda.Text = "Seleccione";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
