﻿using QrMenu.BusinessLayer.Abstract;
using QrMenu.DataAccessLayer.Abstract;
using QrMenu.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.BusinessLayer.Concrate
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

		public int TActiveCategoryCount()
		{
			return _categoryDal.ActiveCategoryCount();
		}

		public void TAdd(Category entity)
        {
            _categoryDal.Add(entity);  
        }

		public int TCategoryCount()
		{
			return _categoryDal.CategoryCount();
		}

		public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> TGetListAll()
        {
           return _categoryDal.GetListAll();
        }

		public int TPassiveCategoryCount()
		{
			return _categoryDal.PassiveCategoryCount();
		}

		public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
