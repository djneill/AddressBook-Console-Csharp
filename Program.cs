
using nameAddress;
using nameAddress.Models;
using nameAddress.Processors;
using nameAddress.Services;



List<PersonModel> people = new List<PersonModel>();

while (true)
{
    PersonModel person = InputService.GetPersonInput();
    if (person == null) break;

    person.HomeAddress = InputService.GetAddressInput();
    people.Add(person);

}

foreach (PersonModel person in people)
{
    Console.WriteLine();
    ProcessPerson.PersonDetails(person);

}
