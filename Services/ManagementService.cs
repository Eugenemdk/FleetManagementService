using Grpc.Core;

namespace FleetManagement.Services
{
    public class ManagementService : FleetService.FleetServiceBase
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        List<Driver> drivers;
        List<Waypoint> waypoints;
        List<Route> routes;

        public override Task<InfoRequestResponse> AddVehicle(Vehicle request, ServerCallContext context)
        {
            Vehicle vehicle = new Vehicle
            {
                VehicleId = request.VehicleId,
                LicensePlate = request.LicensePlate,
                Make = request.Make,
                Model = request.Model,
                Latitude = request.Latitude,
                Longitude = request.Longitude,
            };

            return Task.FromResult(new InfoRequestResponse
            {
                StatusMessage = "OK",
                StatusCode = 0
            });

        }
    }
}
