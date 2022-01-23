using Xackathon.Bll.Model;
using Xackathon.Dal.Models;

namespace Xackathon.Bll
{
    static class DomainHelper
    {
        public static IEnumerable<RoleDomainModel> ToRoleDomainArray(this IEnumerable<Role> model)
        {
            return model == null ? null : model.Select(x => new RoleDomainModel()
            {
                Id = x.Id,
                Slug = x.MnemonicName,
                Title = x.Title,
                CreatedAt = x.CreatedAt.ToFormatString(),
                DeletedAt = x.DeletedAt.ToFormatString(),
                UpdatedAt = x.UpdatedAt.ToFormatString()
            });
        }
        public static RoleDomainModel ToRoleDomain(this Role model)
        {
            if (model == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return new RoleDomainModel()
            {
                Id = model.Id,
                Slug = model.MnemonicName,
                Title = model.Title,
                CreatedAt = model.CreatedAt.ToFormatString(),
                DeletedAt = model.DeletedAt.ToFormatString(),
                UpdatedAt = model.UpdatedAt.ToFormatString()
            };
        }
        public static IEnumerable<RegionDomainModel> ToRegionDomainArray(this IEnumerable<Region> model)
        {
            return model.Select(x => new RegionDomainModel
            {
                Id = x.Id,
                Title = x.Title,
                IsActive = x.IsActive,
                Positions = x.Positions,
                CreatedAt = x.CreatedAt.ToFormatString(),
                DeletedAt = x.DeletedAt.ToFormatString(),
                UpdatedAt = x.UpdatedAt.ToFormatString()
            });
        }
        public static RegionDomainModel ToRegionDomain(this Region model)
        {
            if (model == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return new RegionDomainModel
            {
                Id = model.Id,
                Title = model.Title,
                IsActive = model.IsActive,
                Positions = model.Positions,
                CreatedAt = model.CreatedAt.ToFormatString(),
                DeletedAt = model.DeletedAt.ToFormatString(),
                UpdatedAt = model.UpdatedAt.ToFormatString()
            };
        }
        public static IEnumerable<ProblemCategoryDomainModel> ToProblemCategoryDomainArray(this IEnumerable<ProblemCategory> model)
        {
            return model.Select(x => new ProblemCategoryDomainModel
            {
                Id = x.Id,
                Title = x.Title,
                Icon = x.Icon,
                IsActive = x.IsActive,
                IsVisible = x.IsVisible,
                HashTag = x.HashTag,
                MnemonicName = x.MnemonicName,
                Rating = x.Rating,
                CreatedAt = x.CreatedAt.ToFormatString(),
                DeletedAt = x.DeletedAt.ToFormatString(),
                UpdatedAt = x.UpdatedAt.ToFormatString()
            });
        }
        public static ProblemCategoryDomainModel ToProblemCategoryDomain(this ProblemCategory model)
        {
            if (model == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return new ProblemCategoryDomainModel
            {
                Id = model.Id,
                Title = model.Title,
                Icon = model.Icon,
                IsActive = model.IsActive,
                IsVisible = model.IsVisible,
                HashTag = model.HashTag,
                MnemonicName = model.MnemonicName,
                Rating = model.Rating,
                CreatedAt = model.CreatedAt.ToFormatString(),
                DeletedAt = model.DeletedAt.ToFormatString(),
                UpdatedAt = model.UpdatedAt.ToFormatString()
            };
        }

        public static IEnumerable<RequestDomainModel> ToRequestDomainArray(this IEnumerable<Request> list) 
        {
            return list.Select(model => new RequestDomainModel
            {
                Id = model.Id,
                UserId = model.ProfileId,
                ParentRequestId = model.ParentRequestId,
                Location = model.Location,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                MediaContentId = model.MediaContentId,
                Content = model.Content,
                Status = model.Status,
                Source = model.Source,
                BaseRating = model.BaseRating,
                WatchCount = model.WatchCount,
                RequestConsiderationAt = model.RequestConsiderationAt.ToFormatString(),
                BeginRequestConsiderationAt = model.BeginRequestConsiderationAt.ToFormatString(),
                CompleteRequestExecutionAt = model.CompleteRequestExecutionAt.ToFormatString(),
                IsModerated = model.IsModerated,
                ModeratorId = model.ModeratorId,
                ProblemDescription = model.ProblemDescription,
                DeletedAt = model.DeletedAt.ToFormatString(),
                CreatedAt = model.CreatedAt.ToFormatString(),
                UpdatedAt = model.UpdatedAt.ToFormatString(),
                ViewCount = model.ViewCount
            });
        }
        public static RequestDomainModel ToRequestDomain(this Request model)
        {
            if (model == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return new RequestDomainModel
            {
                Id = model.Id,
                UserId = model.ProfileId,
                ParentRequestId = model.ParentRequestId,
                Location = model.Location,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                MediaContentId = model.MediaContentId,
                Content = model.Content,
                Status = model.Status,
                Source = model.Source,
                BaseRating = model.BaseRating,
                WatchCount = model.WatchCount,
                RequestConsiderationAt = model.RequestConsiderationAt.ToFormatString(),
                BeginRequestConsiderationAt = model.BeginRequestConsiderationAt.ToFormatString(),
                CompleteRequestExecutionAt = model.CompleteRequestExecutionAt.ToFormatString(),
                IsModerated = model.IsModerated,
                ModeratorId = model.ModeratorId,
                ProblemDescription = model.ProblemDescription,
                DeletedAt = model.DeletedAt.ToFormatString(),
                CreatedAt = model.CreatedAt.ToFormatString(),
                UpdatedAt = model.UpdatedAt.ToFormatString(),
                ViewCount = model.ViewCount
            };
        }
        public static IEnumerable<MediaContentDomainModel> ToMediaDomainArray(this IEnumerable<MediaContent> list)
        {
            return list.Select(model => new MediaContentDomainModel
            {
                Type = model.Type,
                Url = model.Url
            });
        }
        public static MediaContentDomainModel ToMediaDomain(this MediaContent model)
        {
            return new MediaContentDomainModel
            {
                Type = model.Type,
                Url = model.Url
            };
        }
        public static IEnumerable<StoredRequestDomainModel> ToStoredRequestDomainArray(this IEnumerable<StoredRequest> list)
        {
            return list.Select(model => new StoredRequestDomainModel
            {
                Id = model.Id,
                CreatedAt = model.CreatedAt.ToFormatString(),
                Attachments = model.Attachments.ToMediaDomainArray(),
                Description = model.Description,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                ProblemCategories = model.ProblemCategories.ToProblemCategoryDomainArray(),
                DeletedAt = model.DeletedAt.ToFormatString(),
                ProfileId = model.ProfileId,
                UpdatedAt = model.UpdatedAt.ToFormatString()
            });
        }
        public static StoredRequestDomainModel ToStoredRequestDomain(this StoredRequest model)
        {
            return new StoredRequestDomainModel
            {
                Id = model.Id,
                CreatedAt = model.CreatedAt.ToFormatString(),
                Attachments = model.Attachments.ToMediaDomainArray(),
                Description = model.Description,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                ProblemCategories = model.ProblemCategories.ToProblemCategoryDomainArray(),
                DeletedAt = model.DeletedAt.ToFormatString(),
                ProfileId = model.ProfileId,
                UpdatedAt = model.UpdatedAt.ToFormatString()
            };
        }
        public static IEnumerable<StoryDomainModel> ToStoryDomainArray(this IEnumerable<Story> list)
        {
            return list.Select(model => new StoryDomainModel
            {
                Id = model.Id,
                WatchCount = model.WatchCount,
                Author = model.AuthorName,
                Content = model.TextContent,
                ContentType = model.ContentType,
                ContentUrl = model.ContentUrl,
                GroupName = model.GroupName,
                Duration = model.Duration,
                IsActive = model.IsActive,
                LiveTo = model.LiveTo.ToFormatString(),
                Position = model.Position,
                Title = model.Title,
                StoryType = model.StoryType,
                ModeratorId = model.ModeratorId,
                CreatedAt = model.CreatedAt.ToFormatString(),
                DeletedAt = model.DeletedAt.ToFormatString(),
                UpdatedAt = model.UpdatedAt.ToFormatString(),
            });
        }
        public static StoryDomainModel ToStoryDomain(this Story model)
        {
            if (model == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return new StoryDomainModel
            {
                Id = model.Id,
                WatchCount = model.WatchCount,
                Author = model.AuthorName,
                Content = model.TextContent,
                ContentType = model.ContentType,
                ContentUrl = model.ContentUrl,
                GroupName = model.GroupName,
                Duration = model.Duration,
                IsActive = model.IsActive,
                LiveTo = model.LiveTo.ToFormatString(),
                Position = model.Position,
                Title = model.Title,
                StoryType = model.StoryType,
                ModeratorId = model.ModeratorId,
                CreatedAt = model.CreatedAt.ToFormatString(),
                DeletedAt = model.DeletedAt.ToFormatString(),
                UpdatedAt = model.UpdatedAt.ToFormatString(),
            };
        }
        public static ProfileDomainModel ToProfileDomain(this Profile model)
        {
            return model == null ? null : new ProfileDomainModel
            {
                Id = model.Id,
                UserId = model.UserId,
                Name = model.Name,
                Email = model.Email,
                Rating = model.Rating,
                CreatedAt = model.CreatedAt.ToFormatString(),
                DeletedAt = model.DeletedAt.ToFormatString(),
                UpdatedAt = model.UpdatedAt.ToFormatString(),
                IsAnonymousRequests = model.IsAnonymousRequests,
                IsNotificationSms = model.IsNotificationSms,
                Requests = model.Requests.ToRequestDomainArray(),
                StoredRequests = model.StoredRequests.ToStoredRequestDomainArray(),
            };
        }
        public static IEnumerable<UserDomainModel> ToUserDomainArray(this IEnumerable<User> list)
        {
            return list.Select(model=>new UserDomainModel
            {
                Id = model.Id,
                EmailApprovedAt = model.EmailApprovedAt.ToFormatString(),
                ApproveEmailCode = model.ApproveEmailCode,
                ApproveSmsCode = model.ApproveSmsCode,
                BlockedAt = model.BlockedAt.ToFormatString(),
                SmsApprovedAt = model.SmsApprovedAt.ToFormatString(),
                CreatedAt = model.CreatedAt.ToFormatString(),
                DeletedAt = model.DeletedAt.ToFormatString(),
                Password = model.Password,
                Roles = model.Roles.ToRoleDomainArray(),
                Profile = model.Profile.ToProfileDomain(),
                UpdatedAt = model.UpdatedAt.ToFormatString(),
                Login = model.Login,
            });
        }
        public static UserDomainModel ToUserDomain(this User model)
        {
            return new UserDomainModel
            {
                Id = model.Id,
                EmailApprovedAt = model.EmailApprovedAt.ToFormatString(),
                ApproveEmailCode = model.ApproveEmailCode,
                ApproveSmsCode = model.ApproveSmsCode,
                BlockedAt = model.BlockedAt.ToFormatString(),
                SmsApprovedAt = model.SmsApprovedAt.ToFormatString(),
                CreatedAt = model.CreatedAt.ToFormatString(),
                DeletedAt = model.DeletedAt.ToFormatString(),
                Password = model.Password,
                Roles = model.Roles.ToRoleDomainArray(),
                Profile = model.Profile.ToProfileDomain(),
                UpdatedAt = model.UpdatedAt.ToFormatString(),
                Login = model.Login,
            };
        }
    }
}
