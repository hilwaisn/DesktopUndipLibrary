using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUndipLibrary.Controller
{
    internal class ValidasiController
    {
        public bool valId(string id)
        {
            for (int a = 0; a <= id.Length; a++)
            {
                if (id[0] == ' ')
                {
                    MessageBox.Show("Input Id failed", "add Id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public bool valUsername(string user)
        {
            for (int a = 0; a < user.Length; a++)
            {
                if (user[a] == ' ' || user[a] == '_' || user[a] == '&' || user[a] == '-' ||
                    user[a] == '/' || user[a] == '\\' || user[a] == '+' || user[a] == ',' ||
                    user[a] == '\'' || user[a] == '<' || user[a] == '>')
                {
                    MessageBox.Show("Input Username failed", "add username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (user.Length == 0 || user[0] == ' ' || user[user.Length - 1] == ' ')
            {
                MessageBox.Show("Input Username failed", "add username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool valName(string name)
        {
            for (int a = 0; a < name.Length; a++)
            {
                if ((name[a] >= '0' && name[a] <= '9') || name[name.Length-1] == ' ' || name[a] == '-' ||
                    name[a] == '/' || name[a] == '\\' || name[a] == '?' || name[a] == '!' ||
                    name[a] == '@' || name[a] == '#' || name[a] == '$' || name[a] == '%' ||
                    name[a] == '^' || name[a] == '&' || name[a] == '*' || name[a] == '(' ||
                    name[a] == ')' || name[a] == '`' || name[a] == '~' || name[a] == '+' ||
                    name[a] == '=' || name[a] == '[' || name[a] == ']' || name[a] == '{' ||
                    name[a] == '}' || name[a] == ';' || name[a] == '\'' || name[a] == ':' ||
                    name[a] == '\"' || name[a] == ',' || name[a] == '.' || name[a] == '/' ||
                    name[a] == '>' || name[a] == '<' || name[a] == '|')
                {
                    MessageBox.Show("Input Name failed", "add name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public bool valAddress(string address)
        {
            for (int a = 0; a <= address.Length; a++)
            {
                if (((address[a] >= '0' && address[a] <= '9') || address[address.Length - 1] == ' ' ||
                    address[address.Length - 1] == '-' || address[a] == '/' || address[a] == '\\' || address[a] == '?' ||
                    address[a] == '!' || address[a] == '@' || address[a] == '#' || address[a] == '$' || address[a] == '%' ||
                    address[a] == '^' || address[a] == '&' || address[a] == '*' || address[a] == '(' || address[a] == ')' ||
                    address[a] == '`' || address[a] == '~' || address[a] == '-' || address[a] == '+' || address[a] == '=' ||
                    address[a] == '[' || address[a] == ']' || address[a] == '{' || address[a] == '}' || address[a] == ';' ||
                    address[a] == '\'' || address[a] == ':' || address[a] == '\"' || address[a] == ',' || address[a] == '.' ||
                    address[a] == '/' || address[a] == '>' || address[a] == '<' || address[a] == '|'))
                {
                    MessageBox.Show("Input Address failed", "add Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool valPob(string pob)
        {
            for (int a = 0; a <= pob.Length; a++)
            {
                if (((pob[a] >= '0' && pob[a] <= '9') || pob[pob.Length - 1] == ' ' ||
                    pob[pob.Length - 1] == '-' || pob[a] == '/' || pob[a] == '\\' || pob[a] == '?' ||
                    pob[a] == '!' || pob[a] == '@' || pob[a] == '#' || pob[a] == '$' || pob[a] == '%' ||
                    pob[a] == '^' || pob[a] == '&' || pob[a] == '*' || pob[a] == '(' || pob[a] == ')' ||
                    pob[a] == '`' || pob[a] == '~' || pob[a] == '-' || pob[a] == '+' || pob[a] == '=' ||
                    pob[a] == '[' || pob[a] == ']' || pob[a] == '{' || pob[a] == '}' || pob[a] == ';' ||
                    pob[a] == '\'' || pob[a] == ':' || pob[a] == '\"' || pob[a] == ',' || pob[a] == '.' ||
                    pob[a] == '/' || pob[a] == '>' || pob[a] == '<' || pob[a] == '|'))
                {
                    MessageBox.Show("Input Place Of Birth failed", "add Place Of Birth", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool valStudy(string study)
        {
            for (int a = 0; a <= study.Length; a++)
            {
                if (((study[a] >= '4' && study[a] <= '9') && study[a] == '0' || study[study.Length - 1] == ' ' ||
                    study[study.Length - 1] == '-' || study[a] == '/' || study[a] == '\\' || study[a] == '?' ||
                    study[a] == '!' || study[a] == '@' || study[a] == '#' || study[a] == '$' || study[a] == '%' ||
                    study[a] == '^' || study[a] == '&' || study[a] == '*' || study[a] == '(' || study[a] == ')' ||
                    study[a] == '`' || study[a] == '~' || study[a] == '+' || study[a] == '=' ||
                    study[a] == '[' || study[a] == ']' || study[a] == '{' || study[a] == '}' || study[a] == ';' ||
                    study[a] == '\'' || study[a] == ':' || study[a] == '\"' || study[a] == ',' || study[a] == '.' ||
                    study[a] == '/' || study[a] == '>' || study[a] == '<' || study[a] == '|'))
                {
                    MessageBox.Show("Input Study Program failed", "add Study Program", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool valTn(string telp)
        {
            for (int a = 0; a <= telp.Length; a++)
            {
                if (((telp[a] >= 'A' && telp[a] <= 'Z' || telp[a] >= 'a' && telp[a] <= 'z') || telp[telp.Length - 1] > '0' || telp[telp.Length - 1] == ' ' ||
                    telp[telp.Length - 1] == '-' || telp[a] == '/' || telp[a] == '\\' || telp[a] == '?' ||
                    telp[a] == '!' || telp[a] == '@' || telp[a] == '#' || telp[a] == '$' || telp[a] == '%' ||
                    telp[a] == '^' || telp[a] == '&' || telp[a] == '*' || telp[a] == '(' || telp[a] == ')' ||
                    telp[a] == '`' || telp[a] == '~' || telp[a] == '-' || telp[a] == '+' || telp[a] == '=' ||
                    telp[a] == '[' || telp[a] == ']' || telp[a] == '{' || telp[a] == '}' || telp[a] == ';' ||
                    telp[a] == '\'' || telp[a] == ':' || telp[a] == '\"' || telp[a] == ',' || telp[a] == '.' ||
                    telp[a] == '/' || telp[a] == '>' || telp[a] == '<' || telp[a] == '|'))
                {
                    MessageBox.Show("Input Telephon Number failed", "add Telephon Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool valTitle(string title)
        {
            for (int a = 0; a < title.Length; a++)
            {
                if (title[a] == ' ' || title[a] == '-' || title[a] == '/' || title[a] == '\\' ||
                    title[a] == '@' || title[a] == '#' || title[a] == '$' || title[a] == '%' ||
                    title[a] == '^' || title[a] == '*' || title[a] == '`' || title[a] == '~' || title[a] == '+' ||
                    title[a] == '[' || title[a] == ']' || title[a] == '{' || title[a] == '}' || title[a] == ';' ||
                    title[a] == '\'' || title[a] == ':' || title[a] == '\"' || title[a] == ',' || title[a] == '.' ||
                    title[a] == '/' || title[a] == '|')
                {
                    MessageBox.Show("Input Title Program failed", "add Title Program", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}