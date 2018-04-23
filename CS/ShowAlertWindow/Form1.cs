using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowAlertWindow {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            Message msg = new Message();
            alertControl1.Show(this, msg.Caption, msg.Text, "", msg.Image, msg);
        }

        private void alertControl1_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e) {
            //Make the Alert Window opaque
            e.AlertForm.OpacityLevel = 1;
        }

        private void alertControl1_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e) {
            //Process Alert Window click
            Message msg = e.Info.Tag as Message;
            XtraMessageBox.Show(msg.Text, msg.Caption);
        }
    }

    public class Message {
        public Message() {
            this.Caption = "LILA-Supermercado";
            this.Text = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo";
            this.Image = global::ShowAlertWindow.Properties.Resources.opportunities_32x32;
        }
        public string Caption { get; set; }
        public string Text { get; set; }
        public Image Image { get; set; }
    }
}
