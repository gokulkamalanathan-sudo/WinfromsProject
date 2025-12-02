using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace GitHubSigninAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;

            string trimmedEmail = email.Split('@')[0];

            string cleanGuid = Guid.NewGuid().ToString().Split('-')[0];

            string formatedEmail = trimmedEmail + "+" + cleanGuid + "@gmail.com";

            string password = "Eat5starDoNothing";

            string userName = cleanGuid;

            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://github.com/signup");

            Thread.Sleep(2000);

            driver.FindElement(By.Id("email")).SendKeys(formatedEmail);

            Thread.Sleep(1000);

            driver.FindElement(By.Id("password")).SendKeys(password);
            Thread.Sleep(1000);

            driver.FindElement(By.Id("login")).SendKeys(userName);
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            Thread.Sleep(2000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
