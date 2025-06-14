using System; 
using System.IO.Ports; 
using System.Text; 
using System.Windows.Forms; 
  
  
namespace matrixSystemApp 
{ 
    public partial class Form1 : Form 
    { 
        private string currentEffect = "L"; 
  
        
  
        public Form1() 
        { 
            InitializeComponent(); 
            cbPorts.Items.AddRange(SerialPort.GetPortNames()); 
            if (cbPorts.Items.Count > 0) 
            { 
                cbPorts.SelectedIndex = 0; 
            } 
            else 
            { 
                cbPorts.Items.Add("Brak portów"); 
                cbPorts.SelectedIndex = 0; 
                cbPorts.Enabled = false; 
            } 
  
  
               //Check serial port 
            //serialPort1.PortName = "COM5"; 
            //serialPort1.BaudRate = 9600; 
            //try 
            //{ 
            //    serialPort1.Open(); 
            //} 
            //catch (Exception ex) 
            //{ 
            //    MessageBox.Show("Nie można otworzyć portu: " + ex.Message); 
            //} 
        } 
  
        private void btnSend_Click(object sender, EventArgs e) 
        { 
            if (!serialPort1.IsOpen) return; 
  
            string effect = chkBlink.Checked ? "B" : currentEffect; 
            string textToSend = $"{effect}:{tbInput.Text.Trim()}\n"; 
  
            byte[] data = Encoding.ASCII.GetBytes(textToSend); 
            serialPort1.Write(data, 0, data.Length); 
            serialPort1.BaseStream.Flush(); 
        } 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) 
        { 
            if (serialPort1.IsOpen) serialPort1.Close(); 
        } 
  
        private void chkBlink_CheckedChanged(object sender, EventArgs e) 
        { 
            if (chkBlink.Checked) currentEffect = "B"; 
        } 
  
        private void btnScrollUp_Click(object sender, EventArgs e) 
        { 
            currentEffect = "U"; 
            
        } 
  
        private void btnScrollLeft_Click(object sender, EventArgs e) 
        { 
            currentEffect = "L"; 
             
        } 
  
        private void btnReset_Click(object sender, EventArgs e) 
        { 
            if (serialPort1.IsOpen) 
            { 
                string resetCommand = "RESET\n";
                byte[] data = Encoding.ASCII.GetBytes(resetCommand); 
                serialPort1.Write(data, 0, data.Length); 
                serialPort1.BaseStream.Flush(); 
            } 
        } 
  
        private void btnScrollRight_Click(object sender, EventArgs e) 
        { 
            currentEffect = "R"; 
  
        }

        private void btnScrollDown_Click(object sender, EventArgs e)
        {
            currentEffect = "D";
        }
  
        private void btnFade_Click(object sender, EventArgs e) 
        { 
            currentEffect = "F"; 
        } 
  
        private void btnOpening_Click(object sender, EventArgs e) 
        { 
            currentEffect = "O";  
        } 
  
        private void btnClosing_Click(object sender, EventArgs e) 
        { 
            currentEffect = "C"; 
        } 
  
        private void btnMesh_Click(object sender, EventArgs e) 
        { 
            currentEffect = "M"; 
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("Port już jest otwarty.");
                return;
            }

            if (cbPorts.SelectedItem == null ||
                cbPorts.SelectedItem.ToString().StartsWith("Brak"))
            {
                MessageBox.Show("Wybierz poprawny port COM.");
                return;
            }

            serialPort1.PortName = cbPorts.SelectedItem.ToString();
            serialPort1.BaudRate = 9600;

            try
            {
                serialPort1.Open();
                MessageBox.Show("Połączono z " + serialPort1.PortName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd przy otwieraniu portu: " + ex.Message);
            }
        }

        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e) 
        { 
  
        } 
  
        private void btnRefreshPorts_Click(object sender, EventArgs e) 
        { 
            cbPorts.Items.Clear(); 
            cbPorts.Items.AddRange(SerialPort.GetPortNames()); 
            if (cbPorts.Items.Count > 0) 
                cbPorts.SelectedIndex = 0; 
            else 
            { 
                cbPorts.Items.Add("Brak portów"); 
                cbPorts.SelectedIndex = 0; 
                cbPorts.Enabled = false; 
            } 
        } 
    } 
}