namespace SP23.P01.Tests.Web.Dtos;

internal class TrainStation
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }
}

public class TrainStationGetDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}
