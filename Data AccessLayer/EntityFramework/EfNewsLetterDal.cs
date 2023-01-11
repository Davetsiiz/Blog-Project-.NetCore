using Data_AccessLayer.Abstract;
using Data_AccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_AccessLayer.EntityFramework
{
	public class EfNewsLetterDal : GenericRepositoryDal<NewsLetter>, INewsLetterDal
	{
	}
}
