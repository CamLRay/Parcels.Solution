using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/parcel")]
    public ActionResult Index(Parcel myParcel)
    {
      return View(myParcel);
    }

    [HttpGet("/parcel/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcel")]
    public ActionResult Create(double weight, int height, int width, int length)
    {
      Parcel myParcel = new Parcel(weight, height, width, length);
      myParcel.ParcelCostToShip = myParcel.CostToShip();
      myParcel.ParcelVolume = myParcel.Volume();
      return RedirectToAction("Index", myParcel);
    }
  }
}