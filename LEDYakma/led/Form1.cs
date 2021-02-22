using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
namespace aurdno
{
    public partial class Form1 : Form
    {
  


        public Form1()
        {
            InitializeComponent();

        

            button1.Enabled = false;
            button2.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
           foreach (string port in ports)
                comboBox1.Items.Add(port); //Seri portları comBox1' ekleme
            //SerialPort serialPort1 = new SerialPort();
            //serialPort1.PortName = "COM3";
            //serialPort1.BaudRate = 9600;
            //serialPort1.Open();
            //button2.Enabled = false;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString(); //comboBox1'de seçili olan portu port ismine ata
            serialPort1.Open(); //Seri portu aç
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");    //Seri porta "1" gönder    
            label1.Text = "Led Açık";  //Label1'e "Led Açık" yaz
            label1.ForeColor = System.Drawing.Color.Red;
            button2.Enabled = true;    //Button2'yi tıklanabilir hale getir
            button1.Enabled = false;   //Button1'i tıklanamaz hale getir
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");    //Seri porta "0" gönder
            label1.Text = "Led Kapalı";//Label1'e "Led Kapalı" yaz
            label1.ForeColor = System.Drawing.Color.Green;
            button1.Enabled = true;    //Button1'i tıklanabilir hale getir
            button2.Enabled = false;   //Button2'yi tıklanamaz hale getir
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();  //Eğer port açıksa kapat
        }
        private void PortWrite(string message)
        {
            if (serialPort1 != null && serialPort1.IsOpen)
            {
                serialPort1.Write(message);
            
                while (true)
                {
                    label1.Text = serialPort1.ReadLine();
                }

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

    
    }
}

/*
 
 const int LedPin = 13;
int ledState = 0;
void setup()
{ 
  pinMode(LedPin, OUTPUT);
  
  Serial.begin(9600);  
}
void loop()
{ 
    char receiveVal;   
   
    if(Serial.available() > 0)
    {        
        receiveVal = Serial.read();
        
       if(receiveVal == '1')    
          ledState = 1;   
       else
          ledState = 0;     
    }   
      
    digitalWrite(LedPin, ledState); 
      
    delay(50);    
}
 
 */