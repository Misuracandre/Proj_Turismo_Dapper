using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Package
    {
        public readonly static string INSERT = "INSERT INTO Package (IdHotel, IdTicket, IdClient, Value)" + 
                                               "values (@IdHotel, @IdTicket, @IdCLient, @Value)";
        
        public readonly static string GETALL = "SELECT p.Id, p.IdHotel, p.IdTicket, p.IdClient, p.Value" +
                                               "a.Id AS OriginAddressId, a.Street AS OriginStreet, a.Number AS OriginNumber, a.Neighborhood AS OriginNeighborhood, a.ZipCode AS OriginZipCode, a.Extension AS OriginExtension, a.IdCity AS OriginCityId," +
                                               "b.Id AS DestinationAddressId, b.Street AS DestinationStreet, b.Number AS DestinationNumber, b.Neighborhood AS DestinationNeighborhood, b.ZipCode AS DestinationZipCode, b.Extension AS DestinationExtension, b.IdCity AS DestinationCityId," +
                                               "c.Id, c.Name, c.Phone," +
                                               "d.Id, d.Description," +
                                               "FROM Package p" +
                                               "JOIN Address a ON p.OriginAddressId = a.Id" +
                                               "JOIN Address b ON p.DestinationAddressId = b.Id" +
                                               "JOIN City d ON a.IdCity = d.Id" +
                                               "JOIN Hotel h ON p.IdHotel = h.Id" +
                                               "JOIN Ticket t ON p.IdTicket = t.Id" +
                                               "JOIN Client c ON p.IdClient = c.Id";
        public int Id { get; set; }
        public Hotel IdHotel { get; set; }
        public Ticket IdTicket { get; set; }
        public Client IdClient { get; set; }
        public decimal Value { get; set; }
        public DateTime Registration_Date { get; set; }
    }
}
