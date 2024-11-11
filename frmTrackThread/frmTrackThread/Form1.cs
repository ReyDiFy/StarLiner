namespace frmTrackThread
{
    
    public partial class Form1 : Form
    {
        MyThreadClass ThreadMaker = new MyThreadClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread threadA = new Thread(MyThreadClass.Thread1);
            Thread threadB = new Thread(MyThreadClass.Thread2);
            Thread threadC = new Thread(MyThreadClass.Thread1);
            Thread threadD = new Thread(MyThreadClass.Thread2);
            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;
            threadA.Name = "Eeny";
            threadB.Name = "meeny";
            threadC.Name = "miny";
            threadD.Name = "moe";
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();
            threadStateLabel.Text = "-Thread Started-";
            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();
            threadStateLabel.Text = "-Thread Joined-";
            threadStateLabel.Text = "-Thread Stopped-";
            threadStateLabel.Text = "-Thread Unstarted-";


        }
    }
}
