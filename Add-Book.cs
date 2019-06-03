using System.Collections.Generic;

namespace address_book{

    class AddressBook{
        private List<Contact> ContactList = new List<Contact>();
        public void AddContact(Contact contact){
            this.ContactList.Add(contact);
        }
        public Contact GetByEmail(string email){
            foreach(Contact contact in ContactList){
                if(contact.Email == email){
                    return contact;
                }
            }
            return null;
        }
        }
    }
