using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  
namespace sesnor
{
    public partial class Form1 : Form
    {
        private string data;

        public Form1()
        {
            InitializeComponent();
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;                    //textBox1'i yalnızca okunabilir şekilde ayarla
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
            foreach (string port in ports)
                comboBox1.Items.Add(port);               //Seri portları comboBox1'e ekleme
            durdur.Enabled = false;
            baslat.Enabled = false;
            sifirla.Enabled = false;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived); //DataReceived eventini oluşturma
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine();                      //Veriyi al
            this.Invoke(new EventHandler(displayData_event));
        }

        private void displayData_event(object sender, EventArgs e)
        {
         
            textBox1.Text += DateTime.Now.ToString() + "        " + data + "\n"; //Gelen veriyi textBox içine güncel zaman ile ekle
            label1.Text = "HaReket Durumu = " + data;                               //Gelen veriyi label'1 e eşitle
        }


        private void baslat_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;  //ComboBox1'de seçili nesneyi port ismine ata
                serialPort1.BaudRate = 9600;            //BaudRate 9600 olarak ayarla
                serialPort1.Open();                     //Seri portu aç
                durdur.Enabled = true;                  //Durdurma butonunu aktif hale getir
                baslat.Enabled = false;                 //Başlatma butonunu pasif hale getir
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");    //Hata mesajı göster
            }
        }

        private void durdur_Click(object sender, EventArgs e)
        {
            serialPort1.Close();        //Seri Portu kapa
            durdur.Enabled = false;     //Durdurma butonunu pasif hale getir
            baslat.Enabled = true;      //Başlatma butonunu aktif hale getir
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();    //Seri port açıksa kapat
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();           //textBox1'i sıfırla
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            durdur.Enabled = true;
            baslat.Enabled = true;
            sifirla.Enabled = true;
        }
    }
}
/*
 const byte pirPin = 2;
const byte pirLED = 13; // buildin LED
const byte pirLED2 = 8; // optional second LED ??
byte calibrationTime = 5;
boolean pirState = 0, oldpirState = 0;

void setup() {
  Serial.begin(9600); // start serial monitor
  pinMode(pirLED, OUTPUT);
  pinMode(pirLED2, OUTPUT);
  Serial.print("Calibrating");

  for (int i = 0; i < calibrationTime; i++) {
    Serial.print(".");
    delay(1000);
  }
  Serial.println(" done");
  Serial.println("SENSOR ACTIVE");
}

void loop() {
  pirState = digitalRead(pirPin); // read the pin every loop
  if (pirState != oldpirState) { // if it has changed (not the same as before)
    if (pirState) { // if PIR is active
      digitalWrite(pirLED, HIGH); // turn onboard LED on
      Serial.println("Movement detected");
      // more "on" code here, e.g. send alarm to BT/Android
    }
    else { // if PIR is not active
      digitalWrite(pirLED, LOW); // turn onboard LED off
      Serial.println("PIR inactive");
      // more "off" code here
    }
    oldpirState = pirState; // update oldpirState
  }
}
 
 
 */

//https://create.arduino.cc/projecthub/microBob/lcd-liquid-crystal-display-e72c74 kayan yazıymış


 
