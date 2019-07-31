using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ClosedXML.Excel;

namespace StudentCSV
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

            if (Path.GetExtension(filePath)?.ToLower() == ".csv")
            {
                CreateCvsFile(student, filePath);
            }
            else if (Path.GetExtension(filePath)?.ToLower() == ".xlsx")
            {
                CreateXlsxFile(student, filePath);
            }
            else
            {
                throw new FileFormatException("Filtypen skal være csv eller xlsx");
            }
        } 
        #endregion

        #region SaveToCsvFile
        private static void CreateCvsFile(Student student, string filePath)
        {
            // string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\elevdata.csv";
            // Build the file content
            var csv = new StringBuilder();


            if (string.IsNullOrWhiteSpace(File.ReadAllText(filePath)))
            {
                csv.AppendLine($"Fornavn;Mellemnavn;Efternavn;CprNr;Telefon Nummer;Email;EUX;Retning;Grundforløbsskole;Ønsket SKP Lokation;Særlige info");
            }

            var newLine =
                $"{student.FirstName};{student.MiddleName};{student.LastName};{student.CprNr};{student.PhoneNumber};{student.Email};{Convertbool(student.EUX)};{Statics.CorrectEducationDirectionEnumNames[(int)student.EducationDirection]};{Statics.CorrectGfSchoolEnumNames[(int)student.GfSchool]};{student.WantedSkpLocation};{student.SpecialInfo}";
            csv.AppendLine(newLine);

            File.AppendAllText(filePath, csv.ToString(), Encoding.UTF8);
        }
        #endregion

        #region ConvertBool
        private static string Convertbool(bool bbool)
        {
            if (bbool) { return "ja"; } else { return "nej"; }
        }
        #endregion

        #region SaveToExcelFile
        private static void CreateXlsxFile(Student student, string filePath)
        {
            XLWorkbook workBook = new XLWorkbook();

            try
            {
                IXLWorksheet worksheet;
                if (string.IsNullOrWhiteSpace(File.ReadAllText(filePath)))
                {
                    worksheet = workBook.AddWorksheet("ElevData");
                    worksheet.Cell(1, "A").Value = "Fornavn";
                    worksheet.Cell(1, "B").Value = "Mellemnavn";
                    worksheet.Cell(1, "C").Value = "Efternavn";
                    worksheet.Cell(1, "D").Value = "CprNr";
                    worksheet.Cell(1, "E").Value = "Telefon Nummer";
                    worksheet.Cell(1, "F").Value = "Email";
                    worksheet.Cell(1, "G").Value = "EUX";
                    worksheet.Cell(1, "H").Value = "Retning";
                    worksheet.Cell(1, "I").Value = "Grundforløbsskole";
                    worksheet.Cell(1, "J").Value = "Ønsket SKP Lokation";
                    worksheet.Cell(1, "K").Value = "Særlige info";
                }
                else
                {
                    workBook = new XLWorkbook(filePath);
                    worksheet = workBook.Worksheet("ElevData");
                }
                int rowNumber = worksheet.LastRowUsed().RowNumber() + 1;
                worksheet.Cell(rowNumber, "A").Value = student.FirstName;
                worksheet.Cell(rowNumber, "B").Value = student.MiddleName;
                worksheet.Cell(rowNumber, "C").Value = student.LastName;
                worksheet.Cell(rowNumber, "D").Value = student.CprNr;
                worksheet.Cell(rowNumber, "E").Value = student.PhoneNumber;
                worksheet.Cell(rowNumber, "F").Value = student.Email;
                worksheet.Cell(rowNumber, "G").Value = Convertbool(student.EUX);
                worksheet.Cell(rowNumber, "H").Value = Statics.CorrectEducationDirectionEnumNames[(int)student.EducationDirection];
                worksheet.Cell(rowNumber, "I").Value = Statics.CorrectGfSchoolEnumNames[(int)student.GfSchool];
                worksheet.Cell(rowNumber, "J").Value = student.WantedSkpLocation;
                worksheet.Cell(rowNumber, "K").Value = student.SpecialInfo;

                worksheet.Column("A").AdjustToContents();
                worksheet.Column("B").AdjustToContents();
                worksheet.Column("C").AdjustToContents();
                worksheet.Column("D").Hide().AdjustToContents();
                worksheet.Column("E").AdjustToContents();
                worksheet.Column("F").AdjustToContents();
                worksheet.Column("G").AdjustToContents();
                worksheet.Column("H").AdjustToContents();
                worksheet.Column("I").AdjustToContents();
                worksheet.Column("J").AdjustToContents();
                worksheet.Column("K").AdjustToContents();

                workBook.SaveAs(filePath);
            }
            finally
            {
                workBook?.Dispose();
            }
        } 
        #endregion
    }
}

