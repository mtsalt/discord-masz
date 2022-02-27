using Discord;
using MASZ.Enums;
using MASZ.Exceptions;
using MASZ.Extensions;
using MASZ.Models;

namespace MASZ.Repositories
{

    public class AppealRepository : BaseRepository<AppealRepository>
    {
        private AppealRepository(IServiceProvider serviceProvider) : base(serviceProvider) { }
        public static AppealRepository CreateDefault(IServiceProvider serviceProvider) => new(serviceProvider);

        public async Task<Appeal> GetById(int id)
        {
            Appeal appeal = await Database.GetAppeal(id);
            if (appeal == null)
            {
                throw new ResourceNotFoundException($"Appeal {id} not found");
            }
            return appeal;
        }
        public async Task<List<Appeal>> GetForGuild(ulong guildId, int page = 0)
        {
            return await Database.GetAppeals(guildId, page);
        }
        public async Task<Appeal> Create(Appeal appeal, List<AppealAnswer> answers)
        {
            appeal.CreatedAt = DateTime.UtcNow;
            appeal.UpdatedAt = DateTime.UtcNow;
            appeal.InvalidDueToLaterRejoinAt = null;
            appeal.UserCanCreateNewAppeals = null;
            appeal.Status = AppealStatus.Pending;

            Database.SaveAppeal(appeal);
            await Database.SaveChangesAsync();

            AppealAnswerRepository answerRepository = AppealAnswerRepository.CreateDefault(_serviceProvider);
            foreach (AppealAnswer answer in answers)
            {
                answer.Appeal = appeal;
                await answerRepository.Create(answer);
            }

            return appeal;
        }
        public async Task<Appeal> Update(Appeal appeal)
        {
            appeal.UpdatedAt = DateTime.UtcNow;
            Database.UpdateAppeal(appeal);
            await Database.SaveChangesAsync();
            return appeal;
        }
        public async Task<bool> UserIsAllowedToCreateNewAppeal(ulong guildId, ulong userId)
        {
            Appeal lastestAppeal = await Database.GetLatestAppealForUser(guildId, userId);
            if (lastestAppeal == null)
            {
                return true;
            }
            if (lastestAppeal.Status == AppealStatus.Pending)
            {
                return false;
            }
            if (lastestAppeal.Status == AppealStatus.Approved)
            {
                return true;
            }
            if (lastestAppeal.InvalidDueToLaterRejoinAt != null)
            {
                return true;
            }
            if (lastestAppeal.UserCanCreateNewAppeals == null)
            {
                return false;
            }
            return lastestAppeal.UserCanCreateNewAppeals.Value <= DateTime.UtcNow;
        }
        public async Task<List<DbCount>> GetCounts(ulong guildId, DateTime since)
        {
            return await Database.GetAppealCount(guildId, since);
        }
    }
}