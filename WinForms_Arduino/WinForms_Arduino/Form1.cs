//using System
using System.IO.Ports;                  //using�� ���� Ports��� ��ü�� �Ʒ��� namespace �������� ���� �ҷ����°��̴�. 
namespace WinForms_Arduino             //namespace��� Ŀ�ٶ� �����ȿ� ������°�
{
    public partial class Form1 : Form       //Ŭ������ �̸��� �������� �̸��� ���ƾ� �Ѵ�.
    {
        private SerialPort serial_port;     //�ν��Ͻ� ����� ����
        private string serial_arduino_data; //�ν��Ͻ� ����� ����
        public Form1()                      //constructor(������)
        {
            InitializeComponent(); // ������Ʈ�� �ʱ�ȭ
            // ���� �Ʒ� ���� �ڵ�
            // Serial ���̺귯���� ����.
            String[] port_names = SerialPort.GetPortNames();    //Ŭ������ ��ü�� �����ϱ� ���ؼ� �Լ��� �ҹ��ڷ� ����ϴ°��� ����. 
            foreach(var item in port_names)                    // port_name�ȿ� �ִ� �������� �޾ƿ��°�. // lazy ����̶�� �Ѵ�.
            {
                this.textBox_Portnumber.Text = item;          // this�� ������(��ü�� �ּ�)�̴�. �ν��Ͻ� ����鿡 �����ϱ�����
            }
            this.serial_port = new SerialPort();             //�ν����� ����� �ʱ�ȭ // this�� ������(��ü�� �ּ�)�̴�. �ν��Ͻ� ����鿡 �����ϱ�����
        }

        private void label1_Click(object sender, EventArgs e)  //object�� �ֻ��� Ŭ�����̴�. ��� Ŭ������ �ֻ��� Ŭ���� ��� ���¸� �� ������ �ִ�. mother of class
        {

        }

        private void progressBar1_Click(object sender, EventArgs e) //object�� �ֻ��� Ŭ�����̴�. ��� Ŭ������ �ֻ��� Ŭ���� ��� ���¸� �� ������ �ִ�. mother of class
        {

        }

        private void label3_Click(object sender, EventArgs e) //object�� �ֻ��� Ŭ�����̴�. ��� Ŭ������ �ֻ��� Ŭ���� ��� ���¸� �� ������ �ִ�. mother of class
        {

        }

        private void button_OnClick_Open(object sender, EventArgs e) //object�� �ֻ��� Ŭ�����̴�. ��� Ŭ������ �ֻ��� Ŭ���� ��� ���¸� �� ������ �ִ�. mother of class
        {                                                            //���߿� ���� Ŭ������ ���� ������ �־�� �Ѵ�. �ϴ� object�� ������ �������̴�.
        //    this.label_SerialPort.Text = "���� ��ư Ŭ��";
            if(this.serial_port.IsOpen)                              //���� ���� �ڵ�
            {
                this.label_SerialPort.Text = "��Ʈ�� �̹� ���Ƚ��ϴ�.";
                return;
            }
            else
            {
                String temporary = this.textBox_Portnumber.Text;     //������ ���� StringŸ������ �޾ƿ��� ������ ��Ʈ������ ����Ѵ�.
                if(temporary.Equals(String.Empty))
                {
                    Console.WriteLine("��Ʈ�ѹ��� �Է����� �ʾҽ��ϴ�.");
                    return;
                }
                else
                {
                    this.serial_port.PortName = this.textBox_Portnumber.Text;
                    this.serial_port.BaudRate = 115200;
                    this.serial_port.DataBits = 8;
                    this.serial_port.Parity = Parity.None;                                //������ üũ���ִ� ��Ʈ.
                    this.serial_port.DataReceived += Serial_port_DataReceived;            //�����͸� ������ �������� �Լ��� ȣ��Ǿ� �о� ���ڴٴ� �ǹ��̴�.
                    this.serial_port.Open(); // �ø�����Ʈ�� ����( �Ƶ��̳� ����)
                }

            }
        }

        private void Serial_port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"SerialDataReceivedEventArgs e: {e.ToString}");
            this.serial_arduino_data = this.serial_port.ReadLine(); //String
            String[] parsingData = this.serial_arduino_data.Split(','); //�����Ͱ� ���޾� �ö� 25.70, 40.20, �̷��� ���� �迭�� ������ �ִ�.
            String temperature = parsingData[0];
            String humidity = parsingData[1];
            float float_temperature = 0.0F;
            float.TryParse(temperature, out float_temperature); // ���ڿ� -> float
            float float_humidity = 0.0F;
            float.TryParse(humidity, out float_humidity); // ���ڿ� -> float

            this.label_Temperature.Invoke(new Action(() =>
            {
                label_Temperature.Text = temperature;
            }));
            this.label_Humidity.Invoke(new Action(() =>
            {
                label_Humidity.Text = humidity;
            }));

            this.progressBar_Temperature.Invoke(new Action(() =>
            {
                progressBar_Temperature.Value = (int)float_temperature;
            }));
            
            this.progressBar_Humidity.Invoke(new Action(() =>
            {
                progressBar_Humidity.Value = (int)float_humidity;
            }));

        }

        private void button_OnClick_Close(object sender, EventArgs e)
        {
            if (this.serial_port.IsOpen) this.serial_port.Close();
            else this.textBox_Portnumber.Text = "�̹� ������ ���������";
        }
    }
}