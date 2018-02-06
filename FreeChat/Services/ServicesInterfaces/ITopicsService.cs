﻿using FreeChat.Models.Domain;
using FreeChat.Models.DTO;
using FreeChat.Models.Enums;
using System.Collections.Generic;

namespace FreeChat.Services.ServicesInterfaces
{
    public interface ITopicsService
    {
        Topics GetTopicById(long id);
        IEnumerable<Topics> GetActiveTopics();
        IEnumerable<TopicsDto> GetActiveTopicsByGenreId(long id);
        IEnumerable<MainCategoriesDto> GetMainCategories();
        bool AddTopic(TopicsDto chatRoom);
        TopicDeletionVerdictEnum DeleteTopicById(long id);
        TopicValidationPriorEnteringEnum ValidateRoom(long id);
        IEnumerable<TopicsDto> GetUserTopics(string id);
        int RoomsRemainingForUser(string id);
        IEnumerable<TopicsFullDto> GetTopicsFull();

        bool ChangeTopicStatus(long id, bool status);

    }
}
