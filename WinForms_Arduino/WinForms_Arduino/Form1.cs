//using System
using System.IO.Ports;                  //using을 통해 Ports라는 객체를 아래의 namespace 공간에서 부터 불러오는것이다. 
namespace WinForms_Arduino             //namespace라는 커다란 공간안에 묶어놓는것
{
    public partial class Form1 : Form       //클래스의 이름과 생성자의 이름은 같아야 한다.
    {
        private SerialPort serial_port;     //인스턴스 멤버의 선언
        private string serial_arduino_data; //인스턴스 멤버의 선언
        public Form1()                      //constructor(생성자)
        {
            InitializeComponent(); // 컴포넌트를 초기화
            // 여기 아래 부터 코딩
            // Serial 라이브러리를 삽입.
            String[] port_names = SerialPort.GetPortNames();    //클래스와 객체를 구분하기 위해서 함수는 소문자로 사용하는것이 좋다. 
            foreach(var item in port_names)                    // port_name안에 있는 아이템을 받아오는것. // lazy 기법이라고도 한다.
            {
                this.textBox_Portnumber.Text = item;          // this는 포인터(객체의 주소)이다. 인스턴스 멤버들에 접근하기위한
            }
            this.serial_port = new SerialPort();             //인스턴의 멤버의 초기화 // this는 포인터(객체의 주소)이다. 인스턴스 멤버들에 접근하기위한
        }

        private void label1_Click(object sender, EventArgs e)  //object는 최상위 클래스이다. 모든 클래스의 최상위 클래스 모든 형태를 다 받을수 있다. mother of class
        {

        }

        private void progressBar1_Click(object sender, EventArgs e) //object는 최상위 클래스이다. 모든 클래스의 최상위 클래스 모든 형태를 다 받을수 있다. mother of class
        {

        }

        private void label3_Click(object sender, EventArgs e) //object는 최상위 클래스이다. 모든 클래스의 최상위 클래스 모든 형태를 다 받을수 있다. mother of class
        {

        }

        private void button_OnClick_Open(object sender, EventArgs e) //object는 최상위 클래스이다. 모든 클래스의 최상위 클래스 모든 형태를 다 받을수 있다. mother of class
        {                                                            //나중에 하위 클래스로 직접 지정해 주어야 한다. 일단 object로 지정해 놓은것이다.
        //    this.label_SerialPort.Text = "오픈 버튼 클릭";
            if(this.serial_port.IsOpen)                              //오류 방지 코드
            {
                this.label_SerialPort.Text = "포트가 이미 열렸습니다.";
                return;
            }
            else
            {
                String temporary = this.textBox_Portnumber.Text;     //요즘은 전부 String타입으로 받아오기 때문에 스트링으로 사용한다.
                if(temporary.Equals(String.Empty))
                {
                    Console.WriteLine("포트넘버를 입력하지 않았습니다.");
                    return;
                }
                else
                {
                    this.serial_port.PortName = this.textBox_Portnumber.Text;
                    this.serial_port.BaudRate = 115200;
                    this.serial_port.DataBits = 8;
                    this.serial_port.Parity = Parity.None;                                //오류를 체크해주는 포트.
                    this.serial_port.DataReceived += Serial_port_DataReceived;            //데이터를 받으면 오른쪽의 함수가 호출되어 읽어 오겠다는 의미이다.
                    this.serial_port.Open(); // 시리얼포트가 연결( 아두이노 연결)
                }

            }
        }

        private void Serial_port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"SerialDataReceivedEventArgs e: {e.ToString}");
            this.serial_arduino_data = this.serial_port.ReadLine(); //String
            String[] parsingData = this.serial_arduino_data.Split(','); //데이터가 연달아 올때 25.70, 40.20, 이런식 으로 배열로 받을수 있다.
            String temperature = parsingData[0];
            String humidity = parsingData[1];
            float float_temperature = 0.0F;
            float.TryParse(temperature, out float_temperature); // 문자열 -> float
            float float_humidity = 0.0F;
            float.TryParse(humidity, out float_humidity); // 문자열 -> float

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
            else this.textBox_Portnumber.Text = "이미 연결이 끊어졌어요";
        }
    }
}