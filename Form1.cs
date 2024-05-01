namespace ProjectName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string CheckTemp(int temp, int min, int max)
        {
            string response = "It is ";
            if (temp < min)
            {
                response += "too cold";
            }
            else if (temp > max)
            {
                response += "too hot";
            }
            else
            {
                response += "okay";
            }
            return response;
        }
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            string firstName; // variable declaration
            string surname;
            string fullName;
            string response;
            int temp;

            firstName = TbxFirstName.Text;  // variable assignment
            surname = TbxSurname.Text;
            fullName = firstName + " " + surname; // concatenation
            temp = int.Parse(TbxTemperature.Text);  // parsing temp text box to integer

            response = "Welcome " + fullName+". "; // creating a response with concatenation
            response += CheckTemp(temp,15,25);  // calling check temp function with parameters

            MessageBox.Show(response,"Greetings"); // create text box with response
        }
        public string CalculateGrade(int mark)
        {
            string response; // string declaration
            if (mark >= 80) // decision statement
            {
                response = "Distinction";
            }
            else if (mark >= 70)
            {
                response = "Merit";
            }
            else if (mark >= 60)
            {
                response = "Pass";
            }
            else
            {
                response = "Fail";
            }
            return response; // return response
        }
        private void BtnGradeBasedOnMark_Click(object sender, EventArgs e)
        {
            string firstName; // string declaration
            string surname;
            string response;
            string fullName;
            int mark;
            string grade;

            firstName = TbxFirstName.Text; // string assignment
            surname = TbxSurname.Text;
            fullName = firstName + " " + surname; // concatenation
            mark = int.Parse(TbxMark.Text); // parsing text box mark to integer
            response = fullName + " you achieved a mark of " + mark + " and a final grade of "; // response generation

            grade = CalculateGrade(mark); // calls grade calculation method
            response += grade; // adds returned value from method to response
            MessageBox.Show(response, "Grade"); // shows text box
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCbxGuess(10);
        }
        private void FillCbxGuess(int max)
        {
            for (int i = 0; i < max; i++)
            {
                CbxGuess.Items.Add(i.ToString());
            }
        }
        public int GenerateNumber(int max)
        {
            Random rnd = new Random();
            return rnd.Next(max);
        }
        private string CheckGuess(int answer, int guess)
        {
            string response="";
            if (guess == answer)
            {
                response+="Congratulations, you guessed correctly";
            }
            else
            {

                response+="Error, you guessed incorrectly"; 
                if (guess > answer)
                {
                    response += "\nError, you guessed too high";
                }
                if (guess < answer)
                {
                    response += "\nError, you guessed too low";
                }
            }
           
            return response;
        }

        private void BtnPlayGuessingGame_Click(object sender, EventArgs e)
        {
            int answer;
            string temp;
            int guess;

            answer = GenerateNumber(10);
            temp = CbxGuess.Text;
            guess = int.Parse(temp);
            string feedback = CheckGuess(answer, guess);
            MessageBox.Show(feedback, "Guessing Game Feedback");
        }
        InputBoxValidation validateNum = delegate (string val, int? min, int? max)
        {
            string response = "";
            if (val == null)
            {
                return "Value cannot be empty";
            }
            response = CheckInt(val, min, max);
            if (response != "")
            {
                return response;
            }
            return "";
        };
        private static string CheckInt(string val, int? min, int? max)
        {
            if (val == "")
            {
                return "Value cannot be empty";
            }
            if (!int.TryParse(val, out int result))
            {
                return "Error, not a number";
            }
            if (result < min)
            {
                return $"Error, input is too small, it must be greater than {min} value";
            }
            if (result> max)
            {
                return $"Error, input is too big, it must be lesser than {max} value";
            }
            return "";
        }
        public int GetInt(string prompt,int max, int min = 0)
        {
            string temp;
            int value = 0;
            temp = InputBox.Show(prompt, $"Enter {prompt} between {min} and {max} ", validateNum, 0, max);
            value = int.Parse(temp);
            return value;
        }

        private void BtnGuessingGame_P_Click(object sender, EventArgs e)
        {
            const int max = 10;
            int attempt = 0;
            bool valid = false;
            string feedback = "";
            int guess = 0;
            int answer = GenerateNumber(max);
            do
            {
            attempt += 1;
            guess = GetInt("Guess", max);
            feedback = CheckGuess(answer, guess);
            MessageBox.Show(feedback, $"Guessing game feedback on attempt {attempt}");
            

            } while ( (attempt < 3) && (feedback.StartsWith("Error")) );
            if (feedback.StartsWith("Error"))
            {
                MessageBox.Show("You have had all 3 attempts. Better luck next time.");
            }
        }
    }
}