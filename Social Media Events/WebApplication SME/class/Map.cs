using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class Map
	{
        public string MapName { get; set; }
        public int ParentId { get; set; }
        public List<File> Files { get; set; }
        
        public Map(string mapname,int parentId)
        {
            this.MapName = mapname;
            this.ParentId = parentId;
        }
        public override string ToString()
        {
            return "Mapname: " + this.MapName +
                " ParentId: " + this.ParentId +
                " Files: " + this.Files;
        }

        public void AddFile(File file)
        {
            this.Files.Add(file);
        }
	}
}