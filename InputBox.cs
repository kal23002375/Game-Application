using System;
using System.Drawing;
using System.Windows.Forms;

internal class InputBox
{
    public static string Show(string title, string promptText)
    {
        return Show(title, promptText, null, null, null);
    }

    public static string Show(string title, string promptText,
                                    InputBoxValidation validation, int? min, int? max)
    {
        string value = "";
        Form form = new Form();
        Label label = new Label();
        TextBox textBox = new TextBox();
        Button buttonOk = new Button();

        form.Text = title;
        label.Text = promptText;
        textBox.Text = value;

        buttonOk.Text = "OK";
        buttonOk.DialogResult = DialogResult.OK;

        label.SetBounds(9, 20, 372, 13);
        textBox.SetBounds(12, 36, 372, 20);
        buttonOk.SetBounds(228, 72, 75, 23);

        label.AutoSize = true;
        textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
        buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

        form.ClientSize = new Size(396, 107);
        form.Controls.AddRange(new Control[] { label, textBox, buttonOk });
        form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
        form.FormBorderStyle = FormBorderStyle.FixedDialog;
        form.StartPosition = FormStartPosition.CenterScreen;
        form.MinimizeBox = false;
        form.MaximizeBox = false;
        form.AcceptButton = buttonOk;
        if (validation != null)
        {
            form.FormClosing += delegate (object sender, FormClosingEventArgs e) {
                if (form.DialogResult == DialogResult.OK)
                {
                    string errorText = validation(textBox.Text, min, max);

                    if (e.Cancel = (errorText != ""))
                    {
                        MessageBox.Show(form, errorText, "Validation Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Focus();
                    }
                }
            };
        }
        DialogResult dialogResult = form.ShowDialog();
        value = textBox.Text;
        return value;
    }
}

public delegate string InputBoxValidation(string errorMessage, int? min, int? max);

//public delegate string InputBoxValidation(string errorMessage);
