using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Ticket
    {
        public readonly static string INSERT = "INSERT INTO Ticket (IdOrigin, IdDestination, IdCLient, Value)" + 
                                               "VALUES (@IdOrigin, @IdDestination, @IdCLient, @Value)";

        public readonly static string GETALL = "SELECT t.Id, t.IdOrigin, t.IdDestination, t.IdClient," +
                                               " a.Id AS OriginAddressId, a.Street AS OriginStreet, a.Number AS OriginNumber, a.Neighborhood AS OriginNeighborhood, a.ZipCode AS OriginZipCode, a.Extension AS OriginExtension, a.IdCity AS OriginCity," +
                                               " b.Id AS DestinationAddressId, b.Street AS DestinationStreet, b.Number AS DestinationNumber, b.Neighborhood AS DestinationNeighborhood, b.ZipCode AS DestinationZipCode, b.Extension AS DestinationExtension, b.IdCity AS DestinationCity," +
                                               "c.Id, c.Name, c.Phone" +
                                               "d.Description" +
                                               "FROM Ticket t," +
                                               "JOIN Address a ON t.Origin = a.Id" +
                                               "JOIN Address b ON t.Destination = b.Id" +
                                               "JOIN Client c ON t.IdClient = c.Id" +
                                               "JOIN City d ON a.IdCity = d.Id";
        public int Id { get; set; }
        public Address IdOrigin { get; set; }
        public Address IdDestination { get; set; }
        public Client IdClient { get; set; }
        public decimal Value { get; set; }
        public DateTime Registration_Date { get; set; }
    }
}
