
using nameAddress;


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
