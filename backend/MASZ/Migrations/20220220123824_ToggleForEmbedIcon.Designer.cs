﻿// <auto-generated />
using System;
using MASZ.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MASZ.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220220123824_ToggleForEmbedIcon")]
    partial class ToggleForEmbedIcon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MASZ.Models.APIToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("TokenHash")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("TokenSalt")
                        .HasColumnType("longblob");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("APITokens");
                });

            modelBuilder.Entity("MASZ.Models.AppSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuditLogWebhookURL")
                        .HasColumnType("longtext");

                    b.Property<int>("DefaultLanguage")
                        .HasColumnType("int");

                    b.Property<string>("EmbedContent")
                        .HasColumnType("longtext");

                    b.Property<bool>("EmbedShowIcon")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("EmbedTitle")
                        .HasColumnType("longtext");

                    b.Property<bool>("PublicFileMode")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("AppSettings");
                });

            modelBuilder.Entity("MASZ.Models.AutoModerationConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AutoModerationAction")
                        .HasColumnType("int");

                    b.Property<int>("AutoModerationType")
                        .HasColumnType("int");

                    b.Property<int>("ChannelNotificationBehavior")
                        .HasColumnType("int");

                    b.Property<string>("CustomWordFilter")
                        .HasColumnType("longtext");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("IgnoreChannels")
                        .HasColumnType("longtext");

                    b.Property<string>("IgnoreRoles")
                        .HasColumnType("longtext");

                    b.Property<int?>("Limit")
                        .HasColumnType("int");

                    b.Property<int?>("PunishmentDurationMinutes")
                        .HasColumnType("int");

                    b.Property<int?>("PunishmentType")
                        .HasColumnType("int");

                    b.Property<bool>("SendDmNotification")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("SendPublicNotification")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("TimeLimitMinutes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AutoModerationConfigs");
                });

            modelBuilder.Entity("MASZ.Models.AutoModerationEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AssociatedCaseId")
                        .HasColumnType("int");

                    b.Property<int>("AutoModerationAction")
                        .HasColumnType("int");

                    b.Property<int>("AutoModerationType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Discriminator")
                        .HasColumnType("longtext");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("MessageContent")
                        .HasColumnType("longtext");

                    b.Property<ulong>("MessageId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Nickname")
                        .HasColumnType("longtext");

                    b.Property<ulong>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AutoModerationEvents");
                });

            modelBuilder.Entity("MASZ.Models.CaseTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("AnnounceDm")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CaseDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("CaseLabels")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CasePunishedUntil")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CasePunishmentType")
                        .HasColumnType("int");

                    b.Property<string>("CaseTitle")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatedForGuildId")
                        .HasColumnType("bigint unsigned");

                    b.Property<bool>("HandlePunishment")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("SendPublicNotification")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("TemplateName")
                        .HasColumnType("longtext");

                    b.Property<ulong>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("ViewPermission")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CaseTemplates");
                });

            modelBuilder.Entity("MASZ.Models.GuildConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdminRoles")
                        .HasColumnType("longtext");

                    b.Property<bool>("ExecuteWhoisOnJoin")
                        .HasColumnType("tinyint(1)");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("ModInternalNotificationWebhook")
                        .HasColumnType("longtext");

                    b.Property<bool>("ModNotificationDM")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ModPublicNotificationWebhook")
                        .HasColumnType("longtext");

                    b.Property<string>("ModRoles")
                        .HasColumnType("longtext");

                    b.Property<string>("MutedRoles")
                        .HasColumnType("longtext");

                    b.Property<int>("PreferredLanguage")
                        .HasColumnType("int");

                    b.Property<bool>("PublishModeratorInfo")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("StrictModPermissionCheck")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("GuildConfigs");
                });

            modelBuilder.Entity("MASZ.Models.GuildLevelAuditLogConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<ulong>("ChannelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("GuildAuditLogEvent")
                        .HasColumnType("int");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("PingRoles")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("GuildLevelAuditLogConfigs");
                });

            modelBuilder.Entity("MASZ.Models.GuildMotd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Message")
                        .HasColumnType("longtext");

                    b.Property<bool>("ShowMotd")
                        .HasColumnType("tinyint(1)");

                    b.Property<ulong>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.ToTable("GuildMotds");
                });

            modelBuilder.Entity("MASZ.Models.ModCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("AllowComments")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("CaseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CreationType")
                        .HasColumnType("int");

                    b.Property<ulong>("DeletedByUserId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .HasColumnType("longtext");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Labels")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastEditedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("LastEditedByModId")
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime?>("LockedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("LockedByUserId")
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime?>("MarkedToDeleteAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("ModId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Nickname")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("OccuredAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Others")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("PunishedUntil")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("PunishmentActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PunishmentType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<ulong>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<bool>("Valid")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("ModCases");
                });

            modelBuilder.Entity("MASZ.Models.ModCaseComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Message")
                        .HasColumnType("longtext");

                    b.Property<int>("ModCaseId")
                        .HasColumnType("int");

                    b.Property<ulong>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("ModCaseId");

                    b.ToTable("ModCaseComments");
                });

            modelBuilder.Entity("MASZ.Models.ScheduledMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<ulong>("ChannelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatorId")
                        .HasColumnType("bigint unsigned");

                    b.Property<int?>("FailureReason")
                        .HasColumnType("int");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime>("LastEditedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("LastEditedById")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ScheduledFor")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ScheduledMessages");
                });

            modelBuilder.Entity("MASZ.Models.UserInvite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime?>("InviteCreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("InviteIssuerId")
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime>("JoinedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("JoinedUserId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("TargetChannelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("UsedInvite")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UserInvites");
                });

            modelBuilder.Entity("MASZ.Models.UserMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatorUserId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Reason")
                        .HasColumnType("longtext");

                    b.Property<ulong>("UserA")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("UserB")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.ToTable("UserMappings");
                });

            modelBuilder.Entity("MASZ.Models.UserNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<ulong>("CreatorId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.ToTable("UserNotes");
                });

            modelBuilder.Entity("MASZ.Models.ModCaseComment", b =>
                {
                    b.HasOne("MASZ.Models.ModCase", "ModCase")
                        .WithMany("Comments")
                        .HasForeignKey("ModCaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModCase");
                });

            modelBuilder.Entity("MASZ.Models.ModCase", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
