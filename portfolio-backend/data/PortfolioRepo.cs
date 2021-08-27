using System.Collections;
using System.Collections.Generic;
using portfolio_backend.models;

namespace portfolio_backend.data {
    public interface PortfolioRepo{
        SortedList<int,int> mock(int userid);
        User GetUser(string name);
        Project[] GetProjects(int userid);
        Experience[] GetExperiences(int userid);
        Identifier[] GetIdentifiers(int userid);
    }
}