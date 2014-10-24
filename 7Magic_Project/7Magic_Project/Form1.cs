using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7Magic_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[][] matrix, matrix_original;
        bool hasMatrix = false;

        private char[][] Draw7(int n)
        {
            char[][] matrix = new char[n][];
            matrix[0] = new char[n];
            for (int j = 0; j < n; ++j) matrix[0][j] = '1';
            for (int i = 1; i < n; ++i)
            {
                matrix[i] = new char[n];
                for (int j = 0; j < n; ++j)
                {
                    if (j == n - i - 1) matrix[i][j] = '1';
                    else matrix[i][j] = ' ';
                }
            }
            return matrix;
        }

        private char[][] CopyCharMatrix(char[][] charMatrix)
        {
            char[][] newCharMatrix = new char[charMatrix.Length][];
            for (int i = 0; i < charMatrix.Length; ++i)
            {
                newCharMatrix[i] = new char[charMatrix[i].Length];
                for (int j = 0; j < charMatrix[i].Length; ++j)
                    newCharMatrix[i][j] = charMatrix[i][j];
            }
            return newCharMatrix;
        }

        private string[] CharMatToStrArr(char[][] charMatrix)
        {
            string[] strarr = new string[charMatrix.Length];
            for (int i = 0; i < charMatrix.Length; ++i)
                strarr[i] = new String(charMatrix[i]);
            return strarr;
        }

        private string[] CharMatToStrArr(char[][] charMatrix, char appendChar)
        {
            string[] strarr = CharMatToStrArr(charMatrix);
            for (int i = 0; i < strarr.Length; ++i)
                strarr[i] += appendChar;
            return strarr;
        }

        private void DisplaySheet(TextBox obj, char[][] charMatrix)
        {
            string[] strarr = CharMatToStrArr(charMatrix);
            obj.Lines = strarr;
        }

        private void DisplaySheet(TextBox obj, char[][] charMatrix, char appendChar)
        {
            string[] strarr = CharMatToStrArr(charMatrix, appendChar);
            obj.Lines = strarr;
        }

        private void RotateLeft()
        {
            int n = matrix.Length;
            char[][] newMatrix = new char[n][];
            for (int i = 0; i < n; ++i)
            {
                newMatrix[i] = new char[n];
                for (int j = 0; j < n; ++j)
                {
                    newMatrix[i][j] = matrix[j][n - i - 1];
                }
            }
            matrix = newMatrix;
        }

        private void RotateRight()
        {
            int n = matrix.Length;
            char[][] newMatrix = new char[n][];
            for (int i = 0; i < n; ++i)
            {
                newMatrix[i] = new char[n];
                for (int j = 0; j < n; ++j)
                {
                    newMatrix[i][j] = matrix[n - j - 1][i];
                }
            }
            matrix = newMatrix;
        }

        private void FlipVertical()
        {
            int n = matrix.Length;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n / 2; ++j)
                {
                    char temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n - j - 1];
                    matrix[i][n - j - 1] = temp;
                }
            }
        }

        private void FlipHerizon()
        {
            int n = matrix.Length;
            for (int i = 0; i < n / 2; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    char temp = matrix[i][j];
                    matrix[i][j] = matrix[n - i - 1][j];
                    matrix[n - i - 1][j] = temp;
                }
            }
        }

        private void DrawHoles()
        {
            int n = matrix.Length, counter = 0;
            char[][] holes = new char[n][];
            for (int i = 0; i < n; ++i)
            {
                holes[i] = new char[n];
                for (int j = 0; j < n; ++j)
                {
                    if (matrix[i][j] == matrix_original[i][j] && matrix[i][j] == '1')
                    {
                        holes[i][j] = 'X';
                        counter++;
                    }
                    else holes[i][j] = ' ';
                }
            }
            DisplaySheet(holesSheet, holes, '|');
            noHoles.Text = counter.ToString();
        }

        private void initialize_Click(object sender, EventArgs e)
        {
            int size = (int)sizeSelector.Value;
            matrix = Draw7(size);
            matrix_original = CopyCharMatrix(matrix);
            hasMatrix = true;
            DisplaySheet(sheet1, matrix_original);
            DisplaySheet(sheet2, matrix);
            DrawHoles();
        }

        private void rotateL_Click(object sender, EventArgs e)
        {
            if (hasMatrix)
            {
                RotateLeft();
                DisplaySheet(sheet2, matrix);
                DrawHoles();
            }
        }

        private void rotateR_Click(object sender, EventArgs e)
        {
            if (hasMatrix)
            {
                RotateRight();
                DisplaySheet(sheet2, matrix);
                DrawHoles();
            }
        }

        private void flipH_Click(object sender, EventArgs e)
        {
            if (hasMatrix)
            {
                FlipHerizon();
                DisplaySheet(sheet2, matrix);
                DrawHoles();
            }
        }

        private void flipV_Click(object sender, EventArgs e)
        {
            if (hasMatrix)
            {
                FlipVertical();
                DisplaySheet(sheet2, matrix);
                DrawHoles();
            }
        }
    }
}
