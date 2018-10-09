﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimonBase;

namespace AED_SimonTest
{
    public partial class Form1 : SimonForm {        
        Botao[] teste = { Botao.AMARELO, Botao.VERDE, Botao.AMARELO, Botao.VERMELHO, Botao.VERMELHO, Botao.AZUL, Botao.VERDE };
        Queue<Botao> simon = new Queue<Botao>();
        Queue<Botao> player = new Queue<Botao>();
        int nivel = 0;

        public bool verificaNivel() {
            if (nivel == player.Count) {
                return true;
            }
            else return false;
        }
        public Form1(): base() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            
        }
        private void button1_Click(object sender, EventArgs e) {
            int botao = new Random().Next(0,3);
            simon.Enqueue((Botao)botao);
            foreach(Botao b in simon){
                click(b);
                System.Threading.Thread.Sleep(200);
            }
            switchPanel();
        }
        private void btnSair_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void btnVerde_Click(object sender, EventArgs e) {
            player.Enqueue(Botao.VERDE);
            click(Botao.VERDE);
            btnVerde.Checked = false;
        }
        private void btnVermelho_Click(object sender, EventArgs e) {
            player.Enqueue(Botao.VERMELHO);
            click(Botao.VERMELHO);
            btnVermelho.Checked = false;
        }
        private void btnAmarelo_Click(object sender, EventArgs e) {
            player.Enqueue(Botao.AMARELO);
            click(Botao.AMARELO);
            btnAmarelo.Checked = false;
        }
        private void btnAzul_Click(object sender, EventArgs e) {
            player.Enqueue(Botao.AZUL);
            click(Botao.AZUL);
            btnAzul.Checked = false;
        }
        private void switchPanel() {
            btnAmarelo.Enabled = !btnAmarelo.Enabled;
            btnVerde.Enabled = !btnVerde.Enabled;
            btnAzul.Enabled = !btnAzul.Enabled;
            btnVermelho.Enabled = !btnVermelho.Enabled;

            for(int i=0; i<4; i++) {
                paineis[i].Enabled = !paineis[i].Enabled;
            }
        }
    }   
}