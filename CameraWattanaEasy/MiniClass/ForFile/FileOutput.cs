using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class FileOutput {

    public FileOutput() {

    }

    private const string fileName = "result_camera.txt";

    public void Write(string message) {
        try
        {
            File.WriteAllText(fileName, message);
        } catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
