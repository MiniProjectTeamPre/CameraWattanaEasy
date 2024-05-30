using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class FileInput {

    public FileInput() {

    }

    private const string fileName = "cmd_camera.txt";

    public string message;
    public string pathImage;
    public string type;

    public bool flagRead = false;

    public bool ReadFile() {
        bool flag = true;

        try
        {
            if (File.Exists(fileName))
            {
                using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        // Read the contents of the file
                        string contents = streamReader.ReadToEnd();
                        if (!string.IsNullOrEmpty(contents))
                        {
                            // Split the contents of the file using '\r\n' as the separator
                            string[] array = contents.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                            // Check that the file contains 4 lines of data
                            if (array.Count() == 4)
                            {
                                // Extract the values from the array
                                message = array[1];
                                pathImage = array[2];
                                type = array[3];
                                flagRead = true;
                            }
                            else
                            {
                                // The file does not contain the expected number of lines
                                flag = false;
                                MessageBox.Show($"Input File Error.{Environment.NewLine}{string.Join(Environment.NewLine, array)}");
                            }
                        }
                    }
                }

                // Delete the file after reading its contents
                File.Delete(fileName);

                if (!flag)
                {
                    // Return false if the file did not contain the expected number of lines
                    return false;
                }
            }
            else
            {
                // The file does not exist
                return false;
            }
        } catch (Exception ex)
        {
            // An error occurred while reading the file
            //MessageBox.Show("An error occurred while checking for the start file: " + ex.Message);
            return false;
        }

        // Return true if the file was successfully read and deleted
        return true;
    }

}
