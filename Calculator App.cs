using Microsoft.VisualBasic.Devices;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    /* Krav:
     * Programmet ska klara av att utföra seriella additioner och multiplikationer
     * Vad som händer när man trycker på = knappen flera gånger
     * Divition med noll ska hanteras
     * Tal som går över maxvärdet på datatypen ska hanteras användarvänligt
     * Ska fungera som windows miniräknare altså den behöver inte bry sig om prioriteringsregler
     * automatiska beräknare är inte tillåtna
     **/
    public partial class main_form : Form
    {
        // Used to store terms(numbers) and signs
        private List<string> terms = new List<string>();
        private List<string> signs = new List<string>();
        
        // Is used to store the last number and last sign used in the previous calculation
        private string[] last_used = new string[2];
        public main_form()
        {
            InitializeComponent();
        }

        // Writing Numbers in the main textbox using buttons
        private void button1_Click(object sender, EventArgs e)
        {
            
            main_textbox.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "0";
        }

        // Writing Signs in the main textbox using buttons
        private void clear_button_Click(object sender, EventArgs e)
        {
            if (main_textbox.Text == "")
            {
                log_listBox.Items.Clear();
                terms.Clear();
                signs.Clear();
                last_used[0] = null;
                last_used[1] = null;
                last_usedLabel.Text = "+ 0";
            }
            else
            {
                main_textbox.Text = "";
                terms.Clear();
                signs.Clear();
            }
        }
        private void plus_button_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "+";
        }
        private void minus_button_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "-";
        }
        private void multiplication_button_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "x";
        }
        private void division_button_Click(object sender, EventArgs e)
        {
            main_textbox.Text += "/";
        }
        private void equal_button_Click(object sender, EventArgs e)
        {
            // check if the input are valid
            if (check_input())
            {
                // save the terms and signs in the terms and signs Lists
                get_terms_signs();
                // Do the calculations
                calculate();
            }
        }

        // Checks if the user used and invalid input such as if 2 signs are used directly after each other
        private bool check_input()
        {
            string input = main_textbox.Text;
            for (int i = 0; i < main_textbox.Text.Length; i++)
            {
                // display error if the input starts or ends with a sign
                if ((input[i] == '+' || input[i] == '-' || input[i] == 'x' || input[i] == '/') && (i == 0  || i == input.Length - 1) && !(i == 0 && main_textbox.Text[i] == '-') )
                {
                    MessageBox.Show("Error!, invalid input!\nYou can't start or end with a sign!!");
                    return false;
                }

                // two signs are used after each other, then display an error!
                if ((input[i] == '+' || input[i] == '-' || input[i] == 'x' || input[i] == '/') && main_textbox.Text.Length != 1 && i+1 != main_textbox.Text.Length)
                {
                    if (input[i+1] == '+' || input[i+1] == 'x' || input[i+1] == '/')
                    {
                        MessageBox.Show("Error!, invalid input!\nYou can't use two signs after each other!");
                        return false;
                    }    
                }
            }
            // display an error if the input does not contain a sign and there is no sign saved since last calculation
            if (last_used[0] == null && !(main_textbox.Text.Contains('+') || main_textbox.Text.Contains('-') || main_textbox.Text.Contains('x') || main_textbox.Text.Contains('/')))
            {
                MessageBox.Show("invalid input!\n There is no sign used!\nPlease check you input!");
                return false;
            }
            
            return true;
        }

        // Get terms and save them in the Lists
        private void get_terms_signs()
        {
            string input = "";
            for (int i = 0; i < main_textbox.Text.Length; i++)
            {
                // Case 1: if the expression starts with a - "minus" then it is indication of a negative number
                if (main_textbox.Text[i] == '-' && i == 0 && main_textbox.Text.Length > 1)
                {
                        input += main_textbox.Text[i];
                }

                // Case 2: if we have a negative number att the middle 
                else if (main_textbox.Text[i] == '-' && main_textbox.Text.Length > 2 && i != 0 && i != main_textbox.Text.Length - 1 && (main_textbox.Text[i - 1] == '+' || main_textbox.Text[i - 1] == '-' || main_textbox.Text[i - 1] == 'x' || main_textbox.Text[i - 1] == '/'))
                {
                        input += main_textbox.Text[i];
                }
                
                // Case 3: if main_textbox.Text[i] is a sign then add the sign to the signs List and add the number in the input variable to the List of terms
                else if (main_textbox.Text[i] == '+' || main_textbox.Text[i] == '-' || main_textbox.Text[i] == 'x' || main_textbox.Text[i] == '/')
                {
                    signs.Add(main_textbox.Text[i].ToString());
                    if (i != 0 && i != main_textbox.Text.Length - 1)
                    {
                        terms.Add(input);
                        input = "";
                    }   
                }
                // case 4: otherwise, the whole number is not yet in the input variable --> continue adding numbers to the input variable
                else
                {
                    input += main_textbox.Text[i];
                    if (i == main_textbox.Text.Length - 1)
                    {
                        terms.Add(input);
                    }
                }
            }
            
            // Use the last sign and number from the previos calculation if (=) button is pressed again
            if (signs.Count == 0 && !(last_used[0] == null && last_used[1] == null))
            {
                signs.Add(last_used[1]); // last sign is stored in the last_used[1]
                terms.Add(last_used[0]); // last term is stored in the last_used[0]
            }
        }
        

        // Calculate 
        private bool calculate()
        {
            int[] int_terms = new int[terms.Count];
            string[] sign_s = new string[signs.Count];
            int result = 0;
            long a = 0, b= 0;

           

            for (int i = 0; i < terms.Count; i++)
            {
                try
                {
                    int_terms[i] = int.Parse(terms.ElementAt(i));
                    if (i < signs.Count)
                    {
                        sign_s[i] = signs.ElementAt(i).ToString();
                    }
                    else if (signs.Count == 0)
                    {
                        MessageBox.Show($"Error!, There is no signs!!");
                        terms.Clear();
                        signs.Clear();
                        return false;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show($"Error!, Your input was not correct!");
                    terms.Clear();
                    signs.Clear();
                    return false;
                }
                catch(Exception e)
                {
                    MessageBox.Show($"Error!, {e.Message}");
                    terms.Clear();
                    signs.Clear();
                    return false;
                }
                
            }

            for (int i = 0; i < int_terms.Length - 1; i++)
            {
                // check if the result of the calculation is greater or smaller than max or min value of int. If out of bounds display an error message
                a = (long)int_terms[i];
                b = (long)int_terms[i + 1];
                if (sign_s[i] == "+" && ((int_terms[i] + int_terms[i + 1] < int.MaxValue) && ((int_terms[i] + int_terms[i + 1] > int.MinValue))))
                {
                    if (a + b > int.MaxValue || a + b < int.MinValue)
                    {
                        MessageBox.Show($"Error!, Exceeded the max or min values.\n please retry with values between{int.MinValue} and {int.MaxValue}!");
                        return false;
                    }
                    int_terms[i + 1] = int_terms[i] + int_terms[i + 1];
                }
                else if (sign_s[i] == "-" && ((int_terms[i] + int_terms[i + 1] < int.MaxValue) && ((int_terms[i] + int_terms[i + 1] > int.MinValue))))
                {
                    if (a - b > int.MaxValue || a - b < int.MinValue)
                    {
                        MessageBox.Show($"Error!, Exceeded the max or min values.\n please retry with values between{int.MinValue} and {int.MaxValue}!");
                        return false;
                    }
                    int_terms[i + 1] = int_terms[i] - int_terms[i + 1];
                }
                else if (sign_s[i] == "x" && ((int_terms[i] + int_terms[i + 1] < int.MaxValue) && ((int_terms[i] + int_terms[i + 1] > int.MinValue))))
                {
                    if (a * b > int.MaxValue || a * b < int.MinValue)
                    {
                        MessageBox.Show($"Error!, Exceeded the max or min values.\n please retry with values between{int.MinValue} and {int.MaxValue}!");
                        return false;
                    }
                    int_terms[i + 1] = int_terms[i] * int_terms[i + 1];
                }
                else if (sign_s[i] == "/" && ((int_terms[i] + int_terms[i + 1] < int.MaxValue) && ((int_terms[i] + int_terms[i + 1] > int.MinValue))))
                {
                    if (int_terms[i + 1] != 0)
                    {
                        if (a / b > int.MaxValue || a / b < int.MinValue)
                        {
                            MessageBox.Show($"Error!, Exceeded the max or min values.\n please retry with values between{int.MinValue} and {int.MaxValue}!");
                            return false;
                        }
                        int_terms[i + 1] = int_terms[i] / int_terms[i + 1];
                    }
                    else
                    {
                        MessageBox.Show("Error!, Division with Zero.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Error, the result is more than the max value of int!");
                }
                result = int_terms[i + 1];
                
            }
            // Save last used term and sign
            try
            {
                last_used[0] = terms.ElementAt(terms.Count - 1);
                last_used[1] = signs.ElementAt(signs.Count - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error, invalid input.");
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error, {e.Message}");
                return false;
            }
            
            
            // Save the last calculation in the log/history
            send_to_log(result);

            // Update last used label
            last_usedLabel.Text = $"{last_used[1]} {last_used[0]}";

            // Display the result
            main_textbox.Text = $"{result}";

            // clear the Lists
            terms.Clear();
            signs.Clear();
            return true;
        }

        // send the result to the log / history
        private void send_to_log(int result)
        {
            string item = "";    
            for (int i = 0; i < terms.Count; i++)
            {
                item += terms.ElementAt(i);
                if(i < signs.Count)
                {
                    item += signs.ElementAt(i);
                }
            }
            log_listBox.Items.Add($"{item}= {result}");
        }

        // Load from log / history
        private void log_listBox_MouseClick(object sender, MouseEventArgs e)
        {
            main_textbox.Text = log_listBox.Text.Split('=')[0];
            signs.Clear();
            terms.Clear();

        }

        // Keyboard - keypressed / allowed keys
         private void main_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == '=')
            {
                if (check_input())
                {
                    get_terms_signs();
                    calculate();
                }
            }
            else if (e.KeyChar == '+')
            {
                main_textbox.Text += "+";
            }
            else if (e.KeyChar == '-')
            {
                main_textbox.Text += "-";
            }
            else if (e.KeyChar == '*')
            {
                main_textbox.Text += "x";
            }
            else if (e.KeyChar == '/')
            {
                main_textbox.Text += "/";
            }
            else if (e.KeyChar == '1')
            {
                main_textbox.Text += "1";
            }
            else if (e.KeyChar == '2')
            {
                main_textbox.Text += "2";
            }
            else if (e.KeyChar == '3')
            {
                main_textbox.Text += "3";
            }
            else if (e.KeyChar == '4')
            {
                main_textbox.Text += "4";
            }
            else if (e.KeyChar == '5')
            {
                main_textbox.Text += "5";
            }
            else if (e.KeyChar == '6')
            {
                main_textbox.Text += "6";
            }
            else if (e.KeyChar == '7')
            {
                main_textbox.Text += "7";
            }
            else if (e.KeyChar == '8')
            {
                main_textbox.Text += "8";
            }
            else if (e.KeyChar == '9')
            {
                main_textbox.Text += "9";
            }
            else if (e.KeyChar == '0')
            {
                main_textbox.Text += "0";
            }
            else if (e.KeyChar == 'c')
            {
                if (main_textbox.Text == "")
                {
                    log_listBox.Items.Clear();
                    terms.Clear();
                    signs.Clear();
                    last_used[0] = null;
                    last_used[1] = null;
                    last_usedLabel.Text = "+ 0";
                }
                else
                {
                    main_textbox.Text = "";
                    terms.Clear();
                    signs.Clear();
                }

            }
            // X key is used to close the program.
            else if (e.KeyChar == 'x')
            {
                if (MessageBox.Show("Do you really want to close?", "exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                }   
            }
            // Backspace key
            else if (e.KeyChar == (char)Keys.Back)
            {
                string backspaced_text = "";
                for (int i = 0; i < main_textbox.Text.Length - 1; i++)
                {
                    backspaced_text += main_textbox.Text[i];
                }
                main_textbox.Text = backspaced_text;
            }
        }

        // backspace button
        private void backspace_button_Click(object sender, EventArgs e)
        {
            string backspaced_text = "";

            // loop and delete the last char
            for (int i = 0; i < main_textbox.Text.Length - 1; i++)
            {
                backspaced_text += main_textbox.Text[i];
            }
            main_textbox.Text = backspaced_text;
        }
    }
}