using System.Collections.Generic;

namespace MVVMCalculator.Model
{
    public class FunctionList
    {
        public List<Function> Collections { get; private set; }

        #region static FunctionList Instance

        private static FunctionList instance = new FunctionList();
        public static FunctionList Instance
        {
            get { return instance; }
        }

        #endregion

        #region コンストラクタ Singleton

        private FunctionList() {
            Load();
        }

        #endregion

        public void Save()
        {
            XML.XMLFileManager.WriteXml<List<Function>>("FunctionData.xml", Collections);
        }

        private void Load()
        {
            Collections = XML.XMLFileManager.ReadXml<List<Function>>("FunctionData.xml");
        }
    }
}
