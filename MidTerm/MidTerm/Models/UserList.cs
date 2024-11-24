using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidTerm.Models
{
    public class UserList
    {
        public static List<User> UsersList = new List<User>()
        {
            new User
            {
                UserLogin = new UserLogin
                {
                    UserId = 1,
                    UserName = "john_doe",
                    Password = "password123"
                },
                UserInfo = new UserInfo
                {
                    UserInfoId = 1,
                    FullName = "John Doe",
                    Bio = "Software developer and tech enthusiast.",
                    Disability = "None",
                    Gender = "Male"
                },
                UserContact = new UserContact
                {
                    UserContactId = 1,
                    MobileNumber = "123-456-7890",
                    Email = "john.doe@example.com",
                    EmergencyContact = "Jane Doe - 321-654-0987",
                    Address = "123 Main St, Springfield"
                }
            },
            new User
            {
                UserLogin = new UserLogin
                {
                    UserId = 2,
                    UserName = "jane_smith",
                    Password = "securePass1"
                },
                UserInfo = new UserInfo
                {
                    UserInfoId = 2,
                    FullName = "Jane Smith",
                    Bio = "Graphic designer and artist.",
                    Disability = "Visual impairment",
                    Gender = "Female"
                },
                UserContact = new UserContact
                {
                    UserContactId = 2,
                    MobileNumber = "987-654-3210",
                    Email = "jane.smith@example.com",
                    EmergencyContact = "John Smith - 654-321-9870",
                    Address = "456 Oak St, Lincoln"
                }
            },
            new User
            {
                UserLogin = new UserLogin
                {
                    UserId = 3,
                    UserName = "alice_jones",
                    Password = "mypassword99"
                },
                UserInfo = new UserInfo
                {
                    UserInfoId = 3,
                    FullName = "Alice Jones",
                    Bio = "Loves hiking and outdoor adventures.",
                    Disability = "None",
                    Gender = "Female"
                },
                UserContact = new UserContact
                {
                    UserContactId = 3,
                    MobileNumber = "555-123-4567",
                    Email = "alice.jones@example.com",
                    EmergencyContact = "Bob Jones - 555-321-7654",
                    Address = "789 Maple Ave, Riverside"
                }
            },
            new User
            {
                UserLogin = new UserLogin
                {
                    UserId = 4,
                    UserName = "mike_brown",
                    Password = "passWord23"
                },
                UserInfo = new UserInfo
                {
                    UserInfoId = 4,
                    FullName = "Mike Brown",
                    Bio = "Avid reader and history buff.",
                    Disability = "Hearing impairment",
                    Gender = "Male"
                },
                UserContact = new UserContact
                {
                    UserContactId = 4,
                    MobileNumber = "444-234-5678",
                    Email = "mike.brown@example.com",
                    EmergencyContact = "Anna Brown - 444-876-5432",
                    Address = "101 Pine Rd, Hilltop"
                }
            },
            new User
            {
                UserLogin = new UserLogin
                {
                    UserId = 5,
                    UserName = "susan_kelly",
                    Password = "kellySecure1"
                },
                UserInfo = new UserInfo
                {
                    UserInfoId = 5,
                    FullName = "Susan Kelly",
                    Bio = "Enjoys photography and traveling.",
                    Disability = "None",
                    Gender = "Female"
                },
                UserContact = new UserContact
                {
                    UserContactId = 5,
                    MobileNumber = "333-987-6543",
                    Email = "susan.kelly@example.com",
                    EmergencyContact = "Tom Kelly - 333-456-7890",
                    Address = "202 Birch Ln, Maplewood"
                }
            },
            new User
            {
                UserLogin = new UserLogin
                {
                    UserId = 6,
                    UserName = "peter_parker",
                    Password = "webCrawl123"
                },
                UserInfo = new UserInfo
                {
                    UserInfoId = 6,
                    FullName = "Peter Parker",
                    Bio = "Photographer and science enthusiast.",
                    Disability = "None",
                    Gender = "Male"
                },
                UserContact = new UserContact
                {
                    UserContactId = 6,
                    MobileNumber = "222-555-7777",
                    Email = "peter.parker@example.com",
                    EmergencyContact = "Mary Jane - 222-111-3333",
                    Address = "303 Cedar Ave, Midtown"
                }
            },
            new User
            {
                UserLogin = new UserLogin
                {
                    UserId = 7,
                    UserName = "lucy_lee",
                    Password = "travelL0ver"
                },
                UserInfo = new UserInfo
                {
                    UserInfoId = 7,
                    FullName = "Lucy Lee",
                    Bio = "Travel blogger and content creator.",
                    Disability = "None",
                    Gender = "Female"
                },
                UserContact = new UserContact
                {
                    UserContactId = 7,
                    MobileNumber = "666-555-4444",
                    Email = "lucy.lee@example.com",
                    EmergencyContact = "Derek Lee - 666-444-3333",
                    Address = "505 Willow St, Greenfield"
                }
            },
            new User
            {
                UserLogin = new UserLogin
                {
                    UserId = 8,
                    UserName = "emma_white",
                    Password = "White2021"
                },
                UserInfo = new UserInfo
                {
                    UserInfoId = 8,
                    FullName = "Emma White",
                    Bio = "Marketing specialist and coffee lover.",
                    Disability = "None",
                    Gender = "Female"
                },
                UserContact = new UserContact
                {
                    UserContactId = 8,
                    MobileNumber = "111-999-8888",
                    Email = "emma.white@example.com",
                    EmergencyContact = "Chris White - 111-777-6666",
                    Address = "707 Aspen Dr, Lakeside"
                }
            },
            new User
            {
                UserLogin = new UserLogin
                {
                    UserId = 9,
                    UserName = "david_clark",
                    Password = "clarkDavid8"
                },
                UserInfo = new UserInfo
                {
                    UserInfoId = 9,
                    FullName = "David Clark",
                    Bio = "Tech enthusiast and gamer.",
                    Disability = "None",
                    Gender = "Male"
                },
                UserContact = new UserContact
                {
                    UserContactId = 9,
                    MobileNumber = "888-777-6666",
                    Email = "david.clark@example.com",
                    EmergencyContact = "Sarah Clark - 888-555-4444",
                    Address = "808 Chestnut St, Oakville"
                }
            },
            new User
            {
                UserLogin = new UserLogin
                {
                    UserId = 10,
                    UserName = "nancy_davis",
                    Password = "NancyD2022"
                },
                UserInfo = new UserInfo
                {
                    UserInfoId = 10,
                    FullName = "Nancy Davis",
                    Bio = "Social worker and volunteer.",
                    Disability = "Mobility impairment",
                    Gender = "Female"
                },
                UserContact = new UserContact
                {
                    UserContactId = 10,
                    MobileNumber = "777-888-9999",
                    Email = "nancy.davis@example.com",
                    EmergencyContact = "Helen Davis - 777-666-5555",
                    Address = "909 Elm St, Roseville"
                }
            }
        };
    }
}
