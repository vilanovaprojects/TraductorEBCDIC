using System.Security.Cryptography;

namespace TraductorEBCDIC
{
    public partial class Form1 : Form
    {
        private bool archivocargado = false;
        private byte[]? data;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            archivocargado = false;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Seleccione un archivo";
            dialog.InitialDirectory = "C:";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string archivoSeleccionado = dialog.FileName;
                long tamanoArchivoBytes = new FileInfo(archivoSeleccionado).Length;       // Validar el tamaño del archivo en bytes
                long tamanoArchivoKB = tamanoArchivoBytes / 1024;                                   // Convertir bytes a kilobytes (KB)
                long limiteTamanoKB = 40;                                                           // Establecer el límite de tamaño permitido en KB (50 KB en este ejemplo)

                if (tamanoArchivoKB > limiteTamanoKB)
                {
                    MessageBox.Show("El archivo seleccionado excede el límite de tamaño permitido de " + limiteTamanoKB + " KB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    archivocargado = true;

                    data = File.ReadAllBytes(archivoSeleccionado);

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (archivocargado)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    switch (data[i])
                    {
                        //00000000000000000000000000000000000000000000000000000000000000000000000000000
                        case 0x00:
                            data[i] = 0x00;
                            break;
                        case 0x01:
                            data[i] = 0x01;
                            break;
                        case 0x02:
                            data[i] = 0x02;
                            break;
                        case 0x03:
                            data[i] = 0x03;
                            break;
                        case 0x04:
                            data[i] = 0x04;
                            break;
                        case 0x05:
                            data[i] = 0x05;
                            break;
                        case 0x06:
                            data[i] = 0x06;
                            break;
                        case 0x07:
                            data[i] = 0x07;
                            break;
                        case 0x08:
                            data[i] = 0x08;
                            break;
                        case 0x09:
                            data[i] = 0x09;
                            break;
                        case 0x0a:
                            data[i] = 0x0a;
                            break;
                        case 0x0b:
                            data[i] = 0x0b;
                            break;
                        case 0x0c:
                            data[i] = 0x0c;
                            break;
                        case 0x0d:
                            data[i] = 0x0d;
                            break;
                        case 0x0e:
                            data[i] = 0x0e;
                            break;
                        case 0x0f:
                            data[i] = 0x0f;
                            break;

                        //11111111111111111111111111111111111111111111111111111111111111111111111111111

                        case 0x10:
                            data[i] = 0x10;
                            break;
                        case 0x11:
                            data[i] = 0x11;
                            break;
                        case 0x12:
                            data[i] = 0x12;
                            break;
                        case 0x13:
                            data[i] = 0x13;
                            break;
                        case 0x14:
                            data[i] = 0x14;
                            break;
                        case 0x15:
                            data[i] = 0x15;
                            break;
                        case 0x16:
                            data[i] = 0x16;
                            break;
                        case 0x17:
                            data[i] = 0x17;
                            break;
                        case 0x18:
                            data[i] = 0x18;
                            break;
                        case 0x19:
                            data[i] = 0x19;
                            break;
                        case 0x1a:
                            data[i] = 0x1a;
                            break;
                        case 0x1b:
                            data[i] = 0x1b;
                            break;
                        case 0x1c:
                            data[i] = 0x1c;
                            break;
                        case 0x1d:
                            data[i] = 0x1d;
                            break;
                        case 0x1e:
                            data[i] = 0x1e;
                            break;
                        case 0x1f:
                            data[i] = 0x1f;
                            break;

                        //22222222222222222222222222222222222222222222222222222222222222222222222222222

                        case 0x20:
                            data[i] = 0x20;
                            break;
                        case 0x21:
                            data[i] = 0x21;
                            break;
                        case 0x22:
                            data[i] = 0x22;
                            break;
                        case 0x23:
                            data[i] = 0x23;
                            break;
                        case 0x24:
                            data[i] = 0x24;
                            break;
                        case 0x25:
                            data[i] = 0x25;
                            break;
                        case 0x26:
                            data[i] = 0x26;
                            break;
                        case 0x27:
                            data[i] = 0x27;
                            break;
                        case 0x28:
                            data[i] = 0x28;
                            break;
                        case 0x29:
                            data[i] = 0x29;
                            break;
                        case 0x2a:
                            data[i] = 0x2a;
                            break;
                        case 0x2b:
                            data[i] = 0x2b;
                            break;
                        case 0x2c:
                            data[i] = 0x2c;
                            break;
                        case 0x2d:
                            data[i] = 0x2d;
                            break;
                        case 0x2e:
                            data[i] = 0x2e;
                            break;
                        case 0x2f:
                            data[i] = 0x2f;
                            break;


                        //33333333333333333333333333333333333333333333333333333333333333333333333333333


                        case 0x30:
                            data[i] = 0x30;
                            break;
                        case 0x31:
                            data[i] = 0x31;
                            break;
                        case 0x32:
                            data[i] = 0x32;
                            break;
                        case 0x33:
                            data[i] = 0x33;
                            break;
                        case 0x34:
                            data[i] = 0x34;
                            break;
                        case 0x35:
                            data[i] = 0x35;
                            break;
                        case 0x36:
                            data[i] = 0x36;
                            break;
                        case 0x37:
                            data[i] = 0x37;
                            break;
                        case 0x38:
                            data[i] = 0x38;
                            break;
                        case 0x39:
                            data[i] = 0x39;
                            break;
                        case 0x3a:
                            data[i] = 0x3a;
                            break;
                        case 0x3b:
                            data[i] = 0x3b;
                            break;
                        case 0x3c:
                            data[i] = 0x3c;
                            break;
                        case 0x3d:
                            data[i] = 0x3d;
                            break;
                        case 0x3e:
                            data[i] = 0x3e;
                            break;
                        case 0x3f:
                            data[i] = 0x3f;
                            break;


                        //44444444444444444444444444444444444444444444444444444444444444444444444444444


                        case 0x40:
                            data[i] = 0x40;
                            break;
                        case 0x41:
                            data[i] = 0x41;
                            break;
                        case 0x42:
                            data[i] = 0x42;
                            break;
                        case 0x43:
                            data[i] = 0x43;
                            break;
                        case 0x44:
                            data[i] = 0x44;
                            break;
                        case 0x45:
                            data[i] = 0x45;
                            break;
                        case 0x46:
                            data[i] = 0x46;
                            break;
                        case 0x47:
                            data[i] = 0x47;
                            break;
                        case 0x48:
                            data[i] = 0x48;
                            break;
                        case 0x49:
                            data[i] = 0x49;
                            break;
                        case 0x4a:
                            data[i] = 0x4a;
                            break;
                        case 0x4b:
                            data[i] = 0x4b;
                            break;
                        case 0x4c:
                            data[i] = 0x4c;
                            break;
                        case 0x4d:
                            data[i] = 0x4d;
                            break;
                        case 0x4e:
                            data[i] = 0x4e;
                            break;
                        case 0x4f:
                            data[i] = 0x4f;
                            break;


                        //55555555555555555555555555555555555555555555555555555555555555555555555555555


                        case 0x50:
                            data[i] = 0x50;
                            break;
                        case 0x51:
                            data[i] = 0x51;
                            break;
                        case 0x52:
                            data[i] = 0x52;
                            break;
                        case 0x53:
                            data[i] = 0x53;
                            break;
                        case 0x54:
                            data[i] = 0x54;
                            break;
                        case 0x55:
                            data[i] = 0x55;
                            break;
                        case 0x56:
                            data[i] = 0x56;
                            break;
                        case 0x57:
                            data[i] = 0x57;
                            break;
                        case 0x58:
                            data[i] = 0x58;
                            break;
                        case 0x59:
                            data[i] = 0x59;
                            break;
                        case 0x5a:
                            data[i] = 0x5a;
                            break;
                        case 0x5b:
                            data[i] = 0x5b;
                            break;
                        case 0x5c:
                            data[i] = 0x5c;
                            break;
                        case 0x5d:
                            data[i] = 0x5d;
                            break;
                        case 0x5e:
                            data[i] = 0x5e;
                            break;
                        case 0x5f:
                            data[i] = 0x5f;
                            break;


                        //66666666666666666666666666666666666666666666666666666666666666666666666666666



                        case 0x60:
                            data[i] = 0x79;     //`
                            break;
                        case 0x61:
                            data[i] = 0x81;     //a
                            break;
                        case 0x62:
                            data[i] = 0x82;     //b
                            break;
                        case 0x63:
                            data[i] = 0x83;     //c
                            break;
                        case 0x64:
                            data[i] = 0x84;     //d
                            break;
                        case 0x65:
                            data[i] = 0x85;     //e
                            break;
                        case 0x66:
                            data[i] = 0x86;     //f
                            break;
                        case 0x67:
                            data[i] = 0x87;     //g
                            break;
                        case 0x68:
                            data[i] = 0x88;     //h
                            break;
                        case 0x69:
                            data[i] = 0x89;     //i
                            break;
                        case 0x6a:
                            data[i] = 0x91;     //j
                            break;
                        case 0x6b:
                            data[i] = 0x92;     //k
                            break;
                        case 0x6c:
                            data[i] = 0x93;     //l
                            break;
                        case 0x6d:
                            data[i] = 0x94;     //m
                            break;
                        case 0x6e:
                            data[i] = 0x95;     //n
                            break;
                        case 0x6f:
                            data[i] = 0x96;     //o
                            break;

                        //77777777777777777777777777777777777777777777777777777777777777777777777777777


                        case 0x70:
                            data[i] = 0x97;     //p
                            break;
                        case 0x71:
                            data[i] = 0x98;     //q
                            break;
                        case 0x72:
                            data[i] = 0x99;     //r
                            break;
                        case 0x73:
                            data[i] = 0xa2;     //s
                            break;
                        case 0x74:
                            data[i] = 0xa3;     //t
                            break;
                        case 0x75:
                            data[i] = 0xa4;     //u
                            break;
                        case 0x76:
                            data[i] = 0xa5;     //v
                            break;
                        case 0x77:
                            data[i] = 0xa6;     //w
                            break;
                        case 0x78:
                            data[i] = 0xa7;     //x
                            break;
                        case 0x79:
                            data[i] = 0xa8;     //y
                            break;
                        case 0x7a:
                            data[i] = 0xa9;     //z
                            break;
                        case 0x7b:
                            data[i] = 0x7b;
                            break;
                        case 0x7c:
                            data[i] = 0x7c;
                            break;
                        case 0x7d:
                            data[i] = 0x7d;
                            break;
                        case 0x7e:
                            data[i] = 0x7e;
                            break;
                        case 0x7f:
                            data[i] = 0x7f;
                            break;

                        //88888888888888888888888888888888888888888888888888888888888888888888888888888


                        case 0x80:
                            data[i] = 0x80;
                            break;
                        case 0x81:
                            data[i] = 0x81;
                            break;
                        case 0x82:
                            data[i] = 0x82;
                            break;
                        case 0x83:
                            data[i] = 0x83;
                            break;
                        case 0x84:
                            data[i] = 0x84;
                            break;
                        case 0x85:
                            data[i] = 0x85;
                            break;
                        case 0x86:
                            data[i] = 0x86;
                            break;
                        case 0x87:
                            data[i] = 0x87;
                            break;
                        case 0x88:
                            data[i] = 0x88;
                            break;
                        case 0x89:
                            data[i] = 0x89;
                            break;
                        case 0x8a:
                            data[i] = 0x8a;
                            break;
                        case 0x8b:
                            data[i] = 0x8b;
                            break;
                        case 0x8c:
                            data[i] = 0x8c;
                            break;
                        case 0x8d:
                            data[i] = 0x8d;
                            break;
                        case 0x8e:
                            data[i] = 0x8e;
                            break;
                        case 0x8f:
                            data[i] = 0x8f;
                            break;

                        //99999999999999999999999999999999999999999999999999999999999999999999999999999


                        case 0x90:
                            data[i] = 0x90;
                            break;
                        case 0x91:
                            data[i] = 0x91;
                            break;
                        case 0x92:
                            data[i] = 0x92;
                            break;
                        case 0x93:
                            data[i] = 0x93;
                            break;
                        case 0x94:
                            data[i] = 0x94;
                            break;
                        case 0x95:
                            data[i] = 0x95;
                            break;
                        case 0x96:
                            data[i] = 0x96;
                            break;
                        case 0x97:
                            data[i] = 0x97;
                            break;
                        case 0x98:
                            data[i] = 0x98;
                            break;
                        case 0x99:
                            data[i] = 0x99;
                            break;
                        case 0x9a:
                            data[i] = 0x9a;
                            break;
                        case 0x9b:
                            data[i] = 0x9b;
                            break;
                        case 0x9c:
                            data[i] = 0x9c;
                            break;
                        case 0x9d:
                            data[i] = 0x9d;
                            break;
                        case 0x9e:
                            data[i] = 0x9e;
                            break;
                        case 0x9f:
                            data[i] = 0x9f;
                            break;


                        //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa


                        case 0xa0:
                            data[i] = 0xa0;
                            break;
                        case 0xa1:
                            data[i] = 0xa1;
                            break;
                        case 0xa2:
                            data[i] = 0xa2;
                            break;
                        case 0xa3:
                            data[i] = 0xa3;
                            break;
                        case 0xa4:
                            data[i] = 0xa4;
                            break;
                        case 0xa5:
                            data[i] = 0xa5;
                            break;
                        case 0xa6:
                            data[i] = 0xa6;
                            break;
                        case 0xa7:
                            data[i] = 0xa7;
                            break;
                        case 0xa8:
                            data[i] = 0xa8;
                            break;
                        case 0xa9:
                            data[i] = 0xa9;
                            break;
                        case 0xaa:
                            data[i] = 0xaa;
                            break;
                        case 0xab:
                            data[i] = 0xab;
                            break;
                        case 0xac:
                            data[i] = 0xac;
                            break;
                        case 0xad:
                            data[i] = 0xad;
                            break;
                        case 0xae:
                            data[i] = 0xae;
                            break;
                        case 0xaf:
                            data[i] = 0xaf;
                            break;

                        //bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb


                        case 0xb0:
                            data[i] = 0xb0;
                            break;
                        case 0xb1:
                            data[i] = 0xb1;
                            break;
                        case 0xb2:
                            data[i] = 0xb2;
                            break;
                        case 0xb3:
                            data[i] = 0xb3;
                            break;
                        case 0xb4:
                            data[i] = 0xb4;
                            break;
                        case 0xb5:
                            data[i] = 0xb5;
                            break;
                        case 0xb6:
                            data[i] = 0xb6;
                            break;
                        case 0xb7:
                            data[i] = 0xb7;
                            break;
                        case 0xb8:
                            data[i] = 0xb8;
                            break;
                        case 0xb9:
                            data[i] = 0xb9;
                            break;
                        case 0xba:
                            data[i] = 0xba;
                            break;
                        case 0xbb:
                            data[i] = 0xbb;
                            break;
                        case 0xbc:
                            data[i] = 0xbc;
                            break;
                        case 0xbd:
                            data[i] = 0xbd;
                            break;
                        case 0xbe:
                            data[i] = 0xbe;
                            break;
                        case 0xbf:
                            data[i] = 0xbf;
                            break;


                        //ccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccc


                        case 0xc0:
                            data[i] = 0xc0;
                            break;
                        case 0xc1:
                            data[i] = 0xc1;
                            break;
                        case 0xc2:
                            data[i] = 0xc2;
                            break;
                        case 0xc3:
                            data[i] = 0xc3;
                            break;
                        case 0xc4:
                            data[i] = 0xc4;
                            break;
                        case 0xc5:
                            data[i] = 0xc5;
                            break;
                        case 0xc6:
                            data[i] = 0xc6;
                            break;
                        case 0xc7:
                            data[i] = 0xc7;
                            break;
                        case 0xc8:
                            data[i] = 0xc8;
                            break;
                        case 0xc9:
                            data[i] = 0xc9;
                            break;
                        case 0xca:
                            data[i] = 0xca;
                            break;
                        case 0xcb:
                            data[i] = 0xcb;
                            break;
                        case 0xcc:
                            data[i] = 0xcc;
                            break;
                        case 0xcd:
                            data[i] = 0xcd;
                            break;
                        case 0xce:
                            data[i] = 0xce;
                            break;
                        case 0xcf:
                            data[i] = 0xcf;
                            break;


                        //ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd


                        case 0xd0:
                            data[i] = 0xd0;
                            break;
                        case 0xd1:
                            data[i] = 0xd1;
                            break;
                        case 0xd2:
                            data[i] = 0xd2;
                            break;
                        case 0xd3:
                            data[i] = 0xd3;
                            break;
                        case 0xd4:
                            data[i] = 0xd4;
                            break;
                        case 0xd5:
                            data[i] = 0xd5;
                            break;
                        case 0xd6:
                            data[i] = 0xd6;
                            break;
                        case 0xd7:
                            data[i] = 0xd7;
                            break;
                        case 0xd8:
                            data[i] = 0xd8;
                            break;
                        case 0xd9:
                            data[i] = 0xd9;
                            break;
                        case 0xda:
                            data[i] = 0xda;
                            break;
                        case 0xdb:
                            data[i] = 0xdb;
                            break;
                        case 0xdc:
                            data[i] = 0xdc;
                            break;
                        case 0xdd:
                            data[i] = 0xdd;
                            break;
                        case 0xde:
                            data[i] = 0xde;
                            break;
                        case 0xdf:
                            data[i] = 0xdf;
                            break;


                        //eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee


                        case 0xe0:
                            data[i] = 0xe0;
                            break;
                        case 0xe1:
                            data[i] = 0xe1;
                            break;
                        case 0xe2:
                            data[i] = 0xe2;
                            break;
                        case 0xe3:
                            data[i] = 0xe3;
                            break;
                        case 0xe4:
                            data[i] = 0xe4;
                            break;
                        case 0xe5:
                            data[i] = 0xe5;
                            break;
                        case 0xe6:
                            data[i] = 0xe6;
                            break;
                        case 0xe7:
                            data[i] = 0xe7;
                            break;
                        case 0xe8:
                            data[i] = 0xe8;
                            break;
                        case 0xe9:
                            data[i] = 0xe9;
                            break;
                        case 0xea:
                            data[i] = 0xea;
                            break;
                        case 0xeb:
                            data[i] = 0xeb;
                            break;
                        case 0xec:
                            data[i] = 0xec;
                            break;
                        case 0xed:
                            data[i] = 0xed;
                            break;
                        case 0xee:
                            data[i] = 0xee;
                            break;
                        case 0xef:
                            data[i] = 0xef;
                            break;


                        //fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff


                        case 0xf0:
                            data[i] = 0xf0;
                            break;
                        case 0xf1:
                            data[i] = 0xf1;
                            break;
                        case 0xf2:
                            data[i] = 0xf2;
                            break;
                        case 0xf3:
                            data[i] = 0xf3;
                            break;
                        case 0xf4:
                            data[i] = 0xf4;
                            break;
                        case 0xf5:
                            data[i] = 0xf5;
                            break;
                        case 0xf6:
                            data[i] = 0xf6;
                            break;
                        case 0xf7:
                            data[i] = 0xf7;
                            break;
                        case 0xf8:
                            data[i] = 0xf8;
                            break;
                        case 0xf9:
                            data[i] = 0xf9;
                            break;
                        case 0xfa:
                            data[i] = 0xfa;
                            break;
                        case 0xfb:
                            data[i] = 0xfb;
                            break;
                        case 0xfc:
                            data[i] = 0xfc;
                            break;
                        case 0xfd:
                            data[i] = 0xfd;
                            break;
                        case 0xfe:
                            data[i] = 0xfe;
                            break;
                        case 0xff:
                            data[i] = 0xff;
                            break;

                    }
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (archivocargado)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Guardar Archivo";
                saveDialog.Filter = "Archivos binarios (*.bin)|*.bin|Todos los archivos (*.*)|*.*"; // Filtro para mostrar solo archivos binarios
                saveDialog.FileName = "archivo_modificado.bin"; // Nombre predeterminado del archivo

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveDialog.FileName;

                    // Guardar el arreglo de bytes en el archivo seleccionado
                    File.WriteAllBytes(rutaArchivo, data);

                    MessageBox.Show("Archivo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
