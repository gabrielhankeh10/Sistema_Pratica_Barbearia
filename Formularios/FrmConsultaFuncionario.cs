﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Formularios
{
    public partial class FrmConsultaFuncionario : Sistema__Renovo_Barber.FrmConsulta
    {
        public FrmConsultaFuncionario()
        {
            InitializeComponent();
        }

        public override void IncluirFormCadastro()
        {
            FrmCadastroFuncionario frmCadastroFuncionario = new FrmCadastroFuncionario();
            frmCadastroFuncionario.ShowDialog();
        }

    }
}
