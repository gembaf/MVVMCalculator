using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MVVMCalculator.Model
{
    public class FunctionList
    {
        #region public static method

        #region FunctionList Instance

        private static FunctionList instance = new FunctionList();
        public static FunctionList Instance
        {
            get { return instance; }
        }

        #endregion

        #endregion

        #region プロパティ

        #region ObservableCollection<Function> Collections

        public ObservableCollection<Function> Collections { get; private set; }
        
        #endregion

        #endregion

        #region コンストラクタ Singleton

        private FunctionList() {
            Load();
        }

        #endregion

        #region デストラクタ

        ~FunctionList()
        {
            Save();
        }

        #endregion

        #region public method

        public void Add(Function func)
        {
            Collections.Add(func);
        }

        #endregion

        #region private method

        private void Save()
        {
            XML.XMLFileManager.WriteXml<ObservableCollection<Function>>("FunctionData.xml", Collections);
        }

        private void Load()
        {
            Collections = XML.XMLFileManager.ReadXml<ObservableCollection<Function>>("FunctionData.xml");
        }

        #endregion
    }
}
