using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NSU_PMS
{
    internal class FormFunctions
    {
        public static void ClearForm(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                // Skip controls that are not input controls
                if (!(control is TextBox || control is ComboBox || control is CheckBox || control is RadioButton || control is ListBox || control is PictureBox))
                {
                    continue;
                }

                if (control.HasChildren)
                {
                    ClearForm(control.Controls); // Recursively clear child controls
                }

                switch (control)
                {
                    case TextBox textBox:
                        textBox.Clear();
                        break;
                    case ComboBox comboBox:
                        comboBox.SelectedIndex = -1;
                        break;
                    case CheckBox checkBox:
                        checkBox.Checked = false;
                        break;
                    case RadioButton radioButton:
                        radioButton.Checked = false;
                        break;
                    case ListBox listBox:
                        listBox.ClearSelected();
                        break;

                        // Add handling for additional control types as needed
                }
            }
        }

        public static bool IsEmailValid(string email)
        {
            // Define a regular expression for validating an Email
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            // Use Regex.IsMatch to check if the email matches the pattern
            if (email == null)
                return false;
            return Regex.IsMatch(email, emailPattern);
        }

        public static bool IsAllDigits(string input)
        {
            if (input == null)
                return false;
            // Use LINQ to check if all characters are digits
            return input.All(char.IsDigit);
        }
        public static bool AreAllInputsValid(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                // Recursively check controls inside containers (like Panels, GroupBoxes)
                if (control.HasChildren)
                {
                    if (!AreAllInputsValid(control.Controls))
                    {
                        return false;
                    }
                }

                // Add specific checks based on control type
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        string controlName = ExtractControlNameWithoutSuffix(control, "TxtBox");
                        MessageBox.Show("Enter value in " + controlName);
                        return false;
                    }
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.SelectedItem == null)
                    {
                        string controlName = ExtractControlNameWithoutSuffix(control, "ComboBox");
                        MessageBox.Show("Enter value in " + controlName);
                        return false;
                    }
                }
                // Add additional control checks as needed (e.g., ListBox, CheckBox, etc.)
            }

            return true;
        }
        public static string ExtractControlNameWithoutSuffix(Control control, string suffixToRemove)
        {
            string controlName = control.Name;

            // Check if the control name ends with the specified suffix
            if (controlName.EndsWith(suffixToRemove, StringComparison.OrdinalIgnoreCase))
            {
                // Remove the suffix from the control name
                return controlName.Substring(0, controlName.Length - suffixToRemove.Length);
            }

            // If the control name doesn't end with the specified suffix, return the original name
            return controlName;
        }

    }
}
