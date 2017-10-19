using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenseLue.Domain.ViewModel
{
    public class MinNoteViewModel
    {
        public string F_Id { get; set; }
        public string F_Title { get; set; }
        public string F_Descripition { get; set; }
        public string F_MindMapFilePath { get; set; }
        public string F_MindMapImagePath { get; set; }
        public string F_SenseWord { get; set; }
        public List<string> F_SenseLabel { get; set; }
        public string F_AuthorId { get; set; }
        public string F_AuthorName { get; set; }
        public string F_Date { get; set; }
        public DateTime? F_CreateTime { get; set; }
    }
}
