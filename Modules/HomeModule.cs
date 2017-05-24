using Nancy;
using PlacesBeen.Objects;
using System.Collections.Generic;

namespace PlacesBeen
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml", Place.GetAll()];
      };
      Get["/places/new"] = _ => {
        return View["place-form.cshtml"];
      };
      Post["/"] = _ => {
        Place newPlace = new Place(Request.Form["new-name"],
                                   Request.Form["new-season"],
                                   Request.Form["new-duration"]);
        return View["index.cshtml", Place.GetAll()];
      };
      Post["/places/clear"] = _ => {
        Place.ClearAll();
        return View["clear.cshtml"];
      };
      Get["/places/{id}"] = parameters => {
        Place targetPlace = Place.Find(parameters.id);
        return View["place-details.cshtml", targetPlace];
      };
    }
  }
}
