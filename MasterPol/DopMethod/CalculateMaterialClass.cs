using MasterPol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPol.DopMethod
{
    public class CalculateMaterialClass
    {
        public int CalcMaterial(int idProd, int idMaterial, int kolvoMaterial)
        {
            using (var context = new MasterPolEntities())
            {
                double? allMaterial = 0;

                var findProdType = context.ProductsType
                    .Where(pt => pt.IdProducsType == idProd)
                    .FirstOrDefault();

                var findTypeMaterial = context.TypeMaterial
                    .Where(tm => tm.IdTypeMaterial == idMaterial)
                    .FirstOrDefault();

                if (findProdType == null || findTypeMaterial == null)
                {
                    return -1;
                }

                var brak = findProdType.KoeffTypeProd * findTypeMaterial.ProcentBrakaMateriala;
                var result = findProdType.KoeffTypeProd * brak;
                
                for (int i = 0;  i!= kolvoMaterial; i++)
                {
                    allMaterial += result;
                }

                var returnResult = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(allMaterial)));
                return returnResult;
            }
        }
    }
}
