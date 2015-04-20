using System.Collections.Generic;

namespace MVVMCalculator.Model
{
    public class FunctionList
    {
        #region プロパティ

        #region List<Function> Collections

        public List<Function> Collections { get; private set; }
        
        #endregion

        #endregion

        #region public static method

        #region FunctionList Instance

        private static FunctionList instance = new FunctionList();
        public static FunctionList Instance
        {
            get { return instance; }
        }

        #endregion

        #endregion

        #region コンストラクタ Singleton

        private FunctionList() {
            Load();
        }

        #endregion

        #region public method

        public void Add(Function func)
        {
            Collections.Add(func);
        }

        public void Save()
        {
            XML.XMLFileManager.WriteXml<List<Function>>("FunctionData.xml", Collections);
        }

        private void Load()
        {
            Collections = XML.XMLFileManager.ReadXml<List<Function>>("FunctionData.xml");
        }

        #endregion
    }
}
