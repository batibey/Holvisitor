﻿using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using hol.visitor.Models;
using ClosedXML.Excel;

namespace hol.visitor.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new();
            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
            }
            return destinationModels;
        }

        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel.xlsx");
            
        }

        public IActionResult DestinationExcelReport()
        {
            using var workBook = new XLWorkbook();
            var workSheet = workBook.Worksheets.Add("Tour List");
            workSheet.Cell(1, 1).Value = "City";
            workSheet.Cell(1, 2).Value = "Night";
            workSheet.Cell(1, 3).Value = "Price";
            workSheet.Cell(1, 4).Value = "Capacity";

            int rowCount = 2;
            foreach (var item in DestinationList())
            {
                workSheet.Cell(rowCount, 1).Value = item.City;
                workSheet.Cell(rowCount, 2).Value = item.DayNight;
                workSheet.Cell(rowCount, 3).Value = item.Price;
                workSheet.Cell(rowCount, 4).Value = item.Capacity;
                rowCount++;
            }

            using var stream = new MemoryStream();
            workBook.SaveAs(stream);
            var content = stream.ToArray();
            return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "NewList.xlsx");
        }
    }
}
