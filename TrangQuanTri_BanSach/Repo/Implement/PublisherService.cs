﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TrangQuanTri_BanSach.Models.Domain;
using TrangQuanTri_BanSach.Repo.Abstract;

namespace TrangQuanTri_BanSach.Repo.Implement
{
  public class PublisherService : IPublisherService
  {
    private readonly DatabaseContext _dbContext;

    public PublisherService(DatabaseContext dbContext)
    {
      _dbContext = dbContext;
    }

    public bool Add(Publisher model)
    {
      try
      {
        _dbContext.Publisher.Add(model);
        _dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception)
      {
        return false;
      }
    }

    public bool Delete(int id)
    {
      try
      {
        var data = FindById(id);
        if (data == null)
        {
          return false;
        }

        _dbContext.Publisher.Remove(data);
        _dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception)
      {
        return false;
      }
    }

    public Publisher FindById(int id)
    {
      return _dbContext.Publisher.Find(id);
    }

    public IEnumerable<Publisher> GetAll()
    {
      return _dbContext.Publisher.ToList();
    }

    public bool Update(Publisher model)
    {
      try
      {
        _dbContext.Publisher.Update(model);
        _dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception)
      {
        return false;
      }
    }



  }
}
