using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using ClosedXML.Excel;
using Microsoft.Win32;
using Spire.Xls;
using StudentCSV.StaticsAndEnums;
using StudentCSV.Views;

namespace StudentCSV.Helpers
{
    public static class DataSaveLocationAndFileType
    {
        #region CreatingFilesTypes
        public static void SaveStudentFile(Student student, string filePath)
        {

            if (!File.Exists(filePath))
            {
                var filestream = File.Create(filePath);
                filestream.Dispose();

            }
            CreateEncryptedFile(student, filePath);

        }
        #endregion

        private static void CreateEncryptedFile(Student student, string filePath)
        {
            // string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\elevdata.csv";
            // Build the file content
            var csv = new StringBuilder();


            if (new FileInfo(filePath).Length == 0)
            {
                // csv.AppendLine($"Fornavn;Mellemnavn;Efternavn;CprNr;Telefon Nummer;Email;zbcEmail;EUX;Retning;Grundforløbsskole;Ønsket SKP Lokation;Særlige info;");
                csv.AppendLine($"Navn;CprNr;Telefon Nummer;Email;Unilogin;EUX;Retning;Grundforløbsskole;Ønsket SKP Lokation;Særlige info;");
            }
            else
            {
                csv.AppendLine(StringCipher.Decrypt(File.ReadAllText(filePath), Statics.Password));
            }

            var newLine =
                $"{student.FullName};{student.CprNr};{student.PhoneNumber};{student.Email};{student.Unilogin};{ConvertBool(student.EUX)};{Statics.CorrectEducationDirectionEnumNames[(int)student.EducationDirection]};{student.GfSchool};{student.WantedSkpLocation};{student.SpecialInfo};";

            csv.AppendLine(newLine);

            File.WriteAllText(filePath, StringCipher.Encrypt(csv.ToString(), Statics.Password), Encoding.UTF8);
        }

        public static bool DecryptFile()
        {
            string password = PasswordWindow.Prompt("Please enter password again", "Enter Password");
            if (!PasswordHelper.VerifyHashedPassword(Statics.Password, password))
            {
                return false;
            }


            string filePath;
            SaveFileDialog Dialog = new SaveFileDialog();
            Dialog.AddExtension = true;
            Dialog.OverwritePrompt = false;
            Dialog.Filter = "CSV Files (*.csv)|*.csv|Excel Files (*.xlsx)|*.xlsx";
            Dialog.FilterIndex = 2;
            var result = Dialog.ShowDialog();

            if (result == true)
            {
                if (Path.GetExtension(Dialog.FileName).ToLower() != ".csv" && Path.GetExtension(Dialog.FileName).ToLower() != ".xlsx")
                {
                    switch (Dialog.FilterIndex)
                    {
                        case 1:
                            Dialog.FileName += ".csv";
                            break;
                        case 2:
                            Dialog.FileName += ".xlsx";
                            break;
                    }
                }
                filePath = Dialog.FileName;
            }
            else
            {
                return false;
            }

            bool fileexist = false;
            if (!File.Exists(filePath))
            {
                var filestream = File.Create(filePath);
                filestream.Dispose();

            }
            else
            {
                fileexist = true;
            }

            if (new FileInfo(filePath).Length > 0)
            {
                throw new FileFormatException(Properties.Resources.MessageBoxNotEmtyFile);
            }

            try
            {
                string file = StringCipher.Decrypt(File.ReadAllText(Statics.Path), Statics.Password);
                if (Path.GetExtension(filePath)?.ToLower() == ".csv")
                {
                    CreateCvsFile(file, filePath);
                }
                else if (Path.GetExtension(filePath)?.ToLower() == ".xlsx")
                {
                    CreateXlsxFile(file, filePath, password);
                }
                else
                {
                    throw new FileFormatException(Properties.Resources.MessageBoxWrongFileFormat);
                }

                return true;
            }
            catch (Exception)
            {
                if (!fileexist)
                {
                    File.Delete(filePath);
                }
                throw;
            }

        }

        #region SaveToCsvFile
        private static void CreateCvsFile(string file, string filePath)
        {
            // string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\elevdata.csv";
            // Build the file content

            file = file.Trim('\n', '\r');
            var fields = file.Substring(0, file.Length - 1).Split(';');
            StringBuilder csv = new StringBuilder();
            for (int index = 0; index < 10; index++)
            {
                string field = fields[index];
                csv.Append($"{field};");
            }
            csv.AppendLine();

            for (int index = 10; index < fields.Length; index++)
            {
                string field = fields[index];
                csv.Append($"\"{field.Trim('\n', '\r')}\";");
                if ((index + 1) % 10 == 0)
                {
                    csv.AppendLine();
                }
            }

            var newFileContent = csv.ToString().Trim('\n', '\r');
            File.WriteAllText(filePath, newFileContent.Substring(0, newFileContent.Length - 1), Encoding.UTF8);
        }
        #endregion

        #region ConvertBool
        private static string ConvertBool(bool bbool)
        {
            if (bbool) { return "ja"; } else { return "nej"; }
        }
        #endregion

        #region SaveToExcelFile
        private static void CreateXlsxFile(string file, string filePath, string password)
        {
            XLWorkbook workBook = new XLWorkbook();

            file = file.Trim('\n', '\r');
            var fields = file.Substring(0, file.Length - 1).Split(';');
            for (int index = 0; index < fields.Length; index++)
            {

                fields[index] = fields[index].Trim('\n', '\r');
            }
            if (fields.Length % 10 != 0)
            {
                throw new FileFormatException(Properties.Resources.MessageBoxEncryptedWrongFormat);
            }

            try
            {
                IXLWorksheet worksheet;
                worksheet = workBook.AddWorksheet("ElevData");
                worksheet.Cell(1, "A").Value = "Navn";
                worksheet.Cell(1, "B").Value = "CprNr";
                worksheet.Cell(1, "C").Value = "Telefon Nummer";
                worksheet.Cell(1, "D").Value = "Email";
                worksheet.Cell(1, "E").Value = "Unilogin";
                worksheet.Cell(1, "F").Value = "EUX";
                worksheet.Cell(1, "G").Value = "Retning";
                worksheet.Cell(1, "H").Value = "Grundforløbsskole";
                worksheet.Cell(1, "I").Value = "Ønsket SKP Lokation";
                worksheet.Cell(1, "J").Value = "Særlige info";

                int i = 10;
                while (fields.Length > i)
                {

                    int rowNumber = worksheet.LastRowUsed().RowNumber() + 1;

                    worksheet.Cell(rowNumber, "A").Value = fields[i++];
                    worksheet.Cell(rowNumber, "B").Value = fields[i++];
                    worksheet.Cell(rowNumber, "C").Value = fields[i++];
                    worksheet.Cell(rowNumber, "D").Value = fields[i++];
                    worksheet.Cell(rowNumber, "E").Value = fields[i++];
                    worksheet.Cell(rowNumber, "F").Value = fields[i++];
                    worksheet.Cell(rowNumber, "G").Value = fields[i++];
                    worksheet.Cell(rowNumber, "H").Value = fields[i++];
                    worksheet.Cell(rowNumber, "I").Value = fields[i++];
                    worksheet.Cell(rowNumber, "J").Value = fields[i++];

                }


                worksheet.Column("A").AdjustToContents();
                worksheet.Column("B").Hide().AdjustToContents();
                worksheet.Column("C").AdjustToContents();
                worksheet.Column("D").AdjustToContents();
                worksheet.Column("E").AdjustToContents();
                worksheet.Column("F").AdjustToContents();
                worksheet.Column("G").AdjustToContents();
                worksheet.Column("H").AdjustToContents();
                worksheet.Column("I").AdjustToContents();
                worksheet.Column("J").AdjustToContents();

                workBook.SaveAs(filePath);
            }
            finally
            {
                workBook?.Dispose();
            }

            using (Spire.Xls.Workbook book = new Workbook())
            {
                book.LoadFromFile(filePath);
                book.Protect(password);
                book.SaveToFile(filePath);
            }
        }
        #endregion
    }
}

