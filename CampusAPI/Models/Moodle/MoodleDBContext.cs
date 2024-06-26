using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace CampusAPI.Models.Moodle;

public partial class MoodleDBContext : DbContext
{
    public MoodleDBContext()
    {
    }

    public MoodleDBContext(DbContextOptions<MoodleDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MdlAnalyticsIndicatorCalc> MdlAnalyticsIndicatorCalcs { get; set; }

    public virtual DbSet<MdlAnalyticsModel> MdlAnalyticsModels { get; set; }

    public virtual DbSet<MdlAnalyticsModelsLog> MdlAnalyticsModelsLogs { get; set; }

    public virtual DbSet<MdlAnalyticsPredictSample> MdlAnalyticsPredictSamples { get; set; }

    public virtual DbSet<MdlAnalyticsPrediction> MdlAnalyticsPredictions { get; set; }

    public virtual DbSet<MdlAnalyticsPredictionAction> MdlAnalyticsPredictionActions { get; set; }

    public virtual DbSet<MdlAnalyticsTrainSample> MdlAnalyticsTrainSamples { get; set; }

    public virtual DbSet<MdlAnalyticsUsedAnalysable> MdlAnalyticsUsedAnalysables { get; set; }

    public virtual DbSet<MdlAnalyticsUsedFile> MdlAnalyticsUsedFiles { get; set; }

    public virtual DbSet<MdlAssign> MdlAssigns { get; set; }

    public virtual DbSet<MdlAssignGrade> MdlAssignGrades { get; set; }

    public virtual DbSet<MdlAssignOverride> MdlAssignOverrides { get; set; }

    public virtual DbSet<MdlAssignPluginConfig> MdlAssignPluginConfigs { get; set; }

    public virtual DbSet<MdlAssignSubmission> MdlAssignSubmissions { get; set; }

    public virtual DbSet<MdlAssignUserFlag> MdlAssignUserFlags { get; set; }

    public virtual DbSet<MdlAssignUserMapping> MdlAssignUserMappings { get; set; }

    public virtual DbSet<MdlAssignfeedbackComment> MdlAssignfeedbackComments { get; set; }

    public virtual DbSet<MdlAssignfeedbackEditpdfAnnot> MdlAssignfeedbackEditpdfAnnots { get; set; }

    public virtual DbSet<MdlAssignfeedbackEditpdfCmnt> MdlAssignfeedbackEditpdfCmnts { get; set; }

    public virtual DbSet<MdlAssignfeedbackEditpdfQueue> MdlAssignfeedbackEditpdfQueues { get; set; }

    public virtual DbSet<MdlAssignfeedbackEditpdfQuick> MdlAssignfeedbackEditpdfQuicks { get; set; }

    public virtual DbSet<MdlAssignfeedbackEditpdfRot> MdlAssignfeedbackEditpdfRots { get; set; }

    public virtual DbSet<MdlAssignfeedbackFile> MdlAssignfeedbackFiles { get; set; }

    public virtual DbSet<MdlAssignment> MdlAssignments { get; set; }

    public virtual DbSet<MdlAssignmentSubmission> MdlAssignmentSubmissions { get; set; }

    public virtual DbSet<MdlAssignmentUpgrade> MdlAssignmentUpgrades { get; set; }

    public virtual DbSet<MdlAssignsubmissionFile> MdlAssignsubmissionFiles { get; set; }

    public virtual DbSet<MdlAssignsubmissionOnlinetext> MdlAssignsubmissionOnlinetexts { get; set; }

    public virtual DbSet<MdlAttendance> MdlAttendances { get; set; }

    public virtual DbSet<MdlAttendanceLog> MdlAttendanceLogs { get; set; }

    public virtual DbSet<MdlAttendanceRotatePassword> MdlAttendanceRotatePasswords { get; set; }

    public virtual DbSet<MdlAttendanceSession> MdlAttendanceSessions { get; set; }

    public virtual DbSet<MdlAttendanceStatus> MdlAttendanceStatuses { get; set; }

    public virtual DbSet<MdlAttendanceTempuser> MdlAttendanceTempusers { get; set; }

    public virtual DbSet<MdlAttendanceWarning> MdlAttendanceWarnings { get; set; }

    public virtual DbSet<MdlAttendanceWarningDone> MdlAttendanceWarningDones { get; set; }

    public virtual DbSet<MdlAuthOauth2LinkedLogin> MdlAuthOauth2LinkedLogins { get; set; }

    public virtual DbSet<MdlBackupController> MdlBackupControllers { get; set; }

    public virtual DbSet<MdlBackupCourse> MdlBackupCourses { get; set; }

    public virtual DbSet<MdlBackupLog> MdlBackupLogs { get; set; }

    public virtual DbSet<MdlBadge> MdlBadges { get; set; }

    public virtual DbSet<MdlBadgeAlignment> MdlBadgeAlignments { get; set; }

    public virtual DbSet<MdlBadgeBackpack> MdlBadgeBackpacks { get; set; }

    public virtual DbSet<MdlBadgeBackpackOauth2> MdlBadgeBackpackOauth2s { get; set; }

    public virtual DbSet<MdlBadgeCriteriaMet> MdlBadgeCriteriaMets { get; set; }

    public virtual DbSet<MdlBadgeCriteriaParam> MdlBadgeCriteriaParams { get; set; }

    public virtual DbSet<MdlBadgeCriterion> MdlBadgeCriteria { get; set; }

    public virtual DbSet<MdlBadgeEndorsement> MdlBadgeEndorsements { get; set; }

    public virtual DbSet<MdlBadgeExternal> MdlBadgeExternals { get; set; }

    public virtual DbSet<MdlBadgeExternalBackpack> MdlBadgeExternalBackpacks { get; set; }

    public virtual DbSet<MdlBadgeExternalIdentifier> MdlBadgeExternalIdentifiers { get; set; }

    public virtual DbSet<MdlBadgeIssued> MdlBadgeIssueds { get; set; }

    public virtual DbSet<MdlBadgeManualAward> MdlBadgeManualAwards { get; set; }

    public virtual DbSet<MdlBadgeRelated> MdlBadgeRelateds { get; set; }

    public virtual DbSet<MdlBlock> MdlBlocks { get; set; }

    public virtual DbSet<MdlBlockCommunity> MdlBlockCommunities { get; set; }

    public virtual DbSet<MdlBlockConfigurableReport> MdlBlockConfigurableReports { get; set; }

    public virtual DbSet<MdlBlockInstance> MdlBlockInstances { get; set; }

    public virtual DbSet<MdlBlockPosition> MdlBlockPositions { get; set; }

    public virtual DbSet<MdlBlockRecentActivity> MdlBlockRecentActivities { get; set; }

    public virtual DbSet<MdlBlockRecentlyaccesseditem> MdlBlockRecentlyaccesseditems { get; set; }

    public virtual DbSet<MdlBlockRssClient> MdlBlockRssClients { get; set; }

    public virtual DbSet<MdlBlogAssociation> MdlBlogAssociations { get; set; }

    public virtual DbSet<MdlBlogExternal> MdlBlogExternals { get; set; }

    public virtual DbSet<MdlBook> MdlBooks { get; set; }

    public virtual DbSet<MdlBookChapter> MdlBookChapters { get; set; }

    public virtual DbSet<MdlCacheFilter> MdlCacheFilters { get; set; }

    public virtual DbSet<MdlCacheFlag> MdlCacheFlags { get; set; }

    public virtual DbSet<MdlCapability> MdlCapabilities { get; set; }

    public virtual DbSet<MdlChat> MdlChats { get; set; }

    public virtual DbSet<MdlChatMessage> MdlChatMessages { get; set; }

    public virtual DbSet<MdlChatMessagesCurrent> MdlChatMessagesCurrents { get; set; }

    public virtual DbSet<MdlChatUser> MdlChatUsers { get; set; }

    public virtual DbSet<MdlChoice> MdlChoices { get; set; }

    public virtual DbSet<MdlChoiceAnswer> MdlChoiceAnswers { get; set; }

    public virtual DbSet<MdlChoiceOption> MdlChoiceOptions { get; set; }

    public virtual DbSet<MdlCohort> MdlCohorts { get; set; }

    public virtual DbSet<MdlCohortMember> MdlCohortMembers { get; set; }

    public virtual DbSet<MdlComment> MdlComments { get; set; }

    public virtual DbSet<MdlCompetency> MdlCompetencies { get; set; }

    public virtual DbSet<MdlCompetencyCoursecomp> MdlCompetencyCoursecomps { get; set; }

    public virtual DbSet<MdlCompetencyCoursecompsetting> MdlCompetencyCoursecompsettings { get; set; }

    public virtual DbSet<MdlCompetencyEvidence> MdlCompetencyEvidences { get; set; }

    public virtual DbSet<MdlCompetencyFramework> MdlCompetencyFrameworks { get; set; }

    public virtual DbSet<MdlCompetencyModulecomp> MdlCompetencyModulecomps { get; set; }

    public virtual DbSet<MdlCompetencyPlan> MdlCompetencyPlans { get; set; }

    public virtual DbSet<MdlCompetencyPlancomp> MdlCompetencyPlancomps { get; set; }

    public virtual DbSet<MdlCompetencyRelatedcomp> MdlCompetencyRelatedcomps { get; set; }

    public virtual DbSet<MdlCompetencyTemplate> MdlCompetencyTemplates { get; set; }

    public virtual DbSet<MdlCompetencyTemplatecohort> MdlCompetencyTemplatecohorts { get; set; }

    public virtual DbSet<MdlCompetencyTemplatecomp> MdlCompetencyTemplatecomps { get; set; }

    public virtual DbSet<MdlCompetencyUsercomp> MdlCompetencyUsercomps { get; set; }

    public virtual DbSet<MdlCompetencyUsercompcourse> MdlCompetencyUsercompcourses { get; set; }

    public virtual DbSet<MdlCompetencyUsercompplan> MdlCompetencyUsercompplans { get; set; }

    public virtual DbSet<MdlCompetencyUserevidence> MdlCompetencyUserevidences { get; set; }

    public virtual DbSet<MdlCompetencyUserevidencecomp> MdlCompetencyUserevidencecomps { get; set; }

    public virtual DbSet<MdlConfig> MdlConfigs { get; set; }

    public virtual DbSet<MdlConfigLog> MdlConfigLogs { get; set; }

    public virtual DbSet<MdlConfigPlugin> MdlConfigPlugins { get; set; }

    public virtual DbSet<MdlContentbankContent> MdlContentbankContents { get; set; }

    public virtual DbSet<MdlContext> MdlContexts { get; set; }

    public virtual DbSet<MdlContextTemp> MdlContextTemps { get; set; }

    public virtual DbSet<MdlCourse> MdlCourses { get; set; }

    public virtual DbSet<MdlCourseCategory> MdlCourseCategories { get; set; }

    public virtual DbSet<MdlCourseCompletion> MdlCourseCompletions { get; set; }

    public virtual DbSet<MdlCourseCompletionAggrMethd> MdlCourseCompletionAggrMethds { get; set; }

    public virtual DbSet<MdlCourseCompletionCritCompl> MdlCourseCompletionCritCompls { get; set; }

    public virtual DbSet<MdlCourseCompletionCriterion> MdlCourseCompletionCriteria { get; set; }

    public virtual DbSet<MdlCourseCompletionDefault> MdlCourseCompletionDefaults { get; set; }

    public virtual DbSet<MdlCourseFormatOption> MdlCourseFormatOptions { get; set; }

    public virtual DbSet<MdlCourseModule> MdlCourseModules { get; set; }

    public virtual DbSet<MdlCourseModulesCompletion> MdlCourseModulesCompletions { get; set; }

    public virtual DbSet<MdlCoursePublished> MdlCoursePublisheds { get; set; }

    public virtual DbSet<MdlCourseRequest> MdlCourseRequests { get; set; }

    public virtual DbSet<MdlCourseSection> MdlCourseSections { get; set; }

    public virtual DbSet<MdlCustomcert> MdlCustomcerts { get; set; }

    public virtual DbSet<MdlCustomcertElement> MdlCustomcertElements { get; set; }

    public virtual DbSet<MdlCustomcertIssue> MdlCustomcertIssues { get; set; }

    public virtual DbSet<MdlCustomcertPage> MdlCustomcertPages { get; set; }

    public virtual DbSet<MdlCustomcertTemplate> MdlCustomcertTemplates { get; set; }

    public virtual DbSet<MdlCustomfieldCategory> MdlCustomfieldCategories { get; set; }

    public virtual DbSet<MdlCustomfieldDatum> MdlCustomfieldData { get; set; }

    public virtual DbSet<MdlCustomfieldField> MdlCustomfieldFields { get; set; }

    public virtual DbSet<MdlDataContent> MdlDataContents { get; set; }

    public virtual DbSet<MdlDataField> MdlDataFields { get; set; }

    public virtual DbSet<MdlDataRecord> MdlDataRecords { get; set; }

    public virtual DbSet<MdlDatum> MdlData { get; set; }

    public virtual DbSet<MdlEditorAttoAutosave> MdlEditorAttoAutosaves { get; set; }

    public virtual DbSet<MdlEnrol> MdlEnrols { get; set; }

    public virtual DbSet<MdlEnrolFlatfile> MdlEnrolFlatfiles { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2Consumer> MdlEnrolLtiLti2Consumers { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2Context> MdlEnrolLtiLti2Contexts { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2Nonce> MdlEnrolLtiLti2Nonces { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2ResourceLink> MdlEnrolLtiLti2ResourceLinks { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2ShareKey> MdlEnrolLtiLti2ShareKeys { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2ToolProxy> MdlEnrolLtiLti2ToolProxies { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2UserResult> MdlEnrolLtiLti2UserResults { get; set; }

    public virtual DbSet<MdlEnrolLtiTool> MdlEnrolLtiTools { get; set; }

    public virtual DbSet<MdlEnrolLtiToolConsumerMap> MdlEnrolLtiToolConsumerMaps { get; set; }

    public virtual DbSet<MdlEnrolLtiUser> MdlEnrolLtiUsers { get; set; }

    public virtual DbSet<MdlEnrolPaypal> MdlEnrolPaypals { get; set; }

    public virtual DbSet<MdlEvent> MdlEvents { get; set; }

    public virtual DbSet<MdlEventSubscription> MdlEventSubscriptions { get; set; }

    public virtual DbSet<MdlEventsHandler> MdlEventsHandlers { get; set; }

    public virtual DbSet<MdlEventsQueue> MdlEventsQueues { get; set; }

    public virtual DbSet<MdlEventsQueueHandler> MdlEventsQueueHandlers { get; set; }

    public virtual DbSet<MdlExternalFunction> MdlExternalFunctions { get; set; }

    public virtual DbSet<MdlExternalService> MdlExternalServices { get; set; }

    public virtual DbSet<MdlExternalServicesFunction> MdlExternalServicesFunctions { get; set; }

    public virtual DbSet<MdlExternalServicesUser> MdlExternalServicesUsers { get; set; }

    public virtual DbSet<MdlExternalToken> MdlExternalTokens { get; set; }

    public virtual DbSet<MdlFavourite> MdlFavourites { get; set; }

    public virtual DbSet<MdlFeedback> MdlFeedbacks { get; set; }

    public virtual DbSet<MdlFeedbackCompleted> MdlFeedbackCompleteds { get; set; }

    public virtual DbSet<MdlFeedbackCompletedtmp> MdlFeedbackCompletedtmps { get; set; }

    public virtual DbSet<MdlFeedbackItem> MdlFeedbackItems { get; set; }

    public virtual DbSet<MdlFeedbackSitecourseMap> MdlFeedbackSitecourseMaps { get; set; }

    public virtual DbSet<MdlFeedbackTemplate> MdlFeedbackTemplates { get; set; }

    public virtual DbSet<MdlFeedbackValue> MdlFeedbackValues { get; set; }

    public virtual DbSet<MdlFeedbackValuetmp> MdlFeedbackValuetmps { get; set; }

    public virtual DbSet<MdlFile> MdlFiles { get; set; }

    public virtual DbSet<MdlFileConversion> MdlFileConversions { get; set; }

    public virtual DbSet<MdlFilesReference> MdlFilesReferences { get; set; }

    public virtual DbSet<MdlFilterActive> MdlFilterActives { get; set; }

    public virtual DbSet<MdlFilterConfig> MdlFilterConfigs { get; set; }

    public virtual DbSet<MdlFilterWirisFormula> MdlFilterWirisFormulas { get; set; }

    public virtual DbSet<MdlFolder> MdlFolders { get; set; }

    public virtual DbSet<MdlForum> MdlForums { get; set; }

    public virtual DbSet<MdlForumDigest> MdlForumDigests { get; set; }

    public virtual DbSet<MdlForumDiscussion> MdlForumDiscussions { get; set; }

    public virtual DbSet<MdlForumDiscussionSub> MdlForumDiscussionSubs { get; set; }

    public virtual DbSet<MdlForumGrade> MdlForumGrades { get; set; }

    public virtual DbSet<MdlForumPost> MdlForumPosts { get; set; }

    public virtual DbSet<MdlForumQueue> MdlForumQueues { get; set; }

    public virtual DbSet<MdlForumRead> MdlForumReads { get; set; }

    public virtual DbSet<MdlForumSubscription> MdlForumSubscriptions { get; set; }

    public virtual DbSet<MdlForumTrackPref> MdlForumTrackPrefs { get; set; }

    public virtual DbSet<MdlGlossary> MdlGlossaries { get; set; }

    public virtual DbSet<MdlGlossaryAlias> MdlGlossaryAliases { get; set; }

    public virtual DbSet<MdlGlossaryCategory> MdlGlossaryCategories { get; set; }

    public virtual DbSet<MdlGlossaryEntriesCategory> MdlGlossaryEntriesCategories { get; set; }

    public virtual DbSet<MdlGlossaryEntry> MdlGlossaryEntries { get; set; }

    public virtual DbSet<MdlGlossaryFormat> MdlGlossaryFormats { get; set; }

    public virtual DbSet<MdlGooglemeet> MdlGooglemeets { get; set; }

    public virtual DbSet<MdlGooglemeetEvent> MdlGooglemeetEvents { get; set; }

    public virtual DbSet<MdlGooglemeetNotifyDone> MdlGooglemeetNotifyDones { get; set; }

    public virtual DbSet<MdlGooglemeetRecording> MdlGooglemeetRecordings { get; set; }

    public virtual DbSet<MdlGradeCategoriesHistory> MdlGradeCategoriesHistories { get; set; }

    public virtual DbSet<MdlGradeCategory> MdlGradeCategories { get; set; }

    public virtual DbSet<MdlGradeGrade> MdlGradeGrades { get; set; }

    public virtual DbSet<MdlGradeGradesHistory> MdlGradeGradesHistories { get; set; }

    public virtual DbSet<MdlGradeImportNewitem> MdlGradeImportNewitems { get; set; }

    public virtual DbSet<MdlGradeImportValue> MdlGradeImportValues { get; set; }

    public virtual DbSet<MdlGradeItem> MdlGradeItems { get; set; }

    public virtual DbSet<MdlGradeItemsHistory> MdlGradeItemsHistories { get; set; }

    public virtual DbSet<MdlGradeLetter> MdlGradeLetters { get; set; }

    public virtual DbSet<MdlGradeOutcome> MdlGradeOutcomes { get; set; }

    public virtual DbSet<MdlGradeOutcomesCourse> MdlGradeOutcomesCourses { get; set; }

    public virtual DbSet<MdlGradeOutcomesHistory> MdlGradeOutcomesHistories { get; set; }

    public virtual DbSet<MdlGradeSetting> MdlGradeSettings { get; set; }

    public virtual DbSet<MdlGradingArea> MdlGradingAreas { get; set; }

    public virtual DbSet<MdlGradingDefinition> MdlGradingDefinitions { get; set; }

    public virtual DbSet<MdlGradingInstance> MdlGradingInstances { get; set; }

    public virtual DbSet<MdlGradingformGuideComment> MdlGradingformGuideComments { get; set; }

    public virtual DbSet<MdlGradingformGuideCriterion> MdlGradingformGuideCriteria { get; set; }

    public virtual DbSet<MdlGradingformGuideFilling> MdlGradingformGuideFillings { get; set; }

    public virtual DbSet<MdlGradingformRubricCriterion> MdlGradingformRubricCriteria { get; set; }

    public virtual DbSet<MdlGradingformRubricFilling> MdlGradingformRubricFillings { get; set; }

    public virtual DbSet<MdlGradingformRubricLevel> MdlGradingformRubricLevels { get; set; }

    public virtual DbSet<MdlGroup> MdlGroups { get; set; }

    public virtual DbSet<MdlGrouping> MdlGroupings { get; set; }

    public virtual DbSet<MdlGroupingsGroup> MdlGroupingsGroups { get; set; }

    public virtual DbSet<MdlGroupsMember> MdlGroupsMembers { get; set; }

    public virtual DbSet<MdlH5p> MdlH5ps { get; set; }

    public virtual DbSet<MdlH5pContentsLibrary> MdlH5pContentsLibraries { get; set; }

    public virtual DbSet<MdlH5pLibrariesCachedasset> MdlH5pLibrariesCachedassets { get; set; }

    public virtual DbSet<MdlH5pLibrary> MdlH5pLibraries { get; set; }

    public virtual DbSet<MdlH5pLibraryDependency> MdlH5pLibraryDependencies { get; set; }

    public virtual DbSet<MdlH5pactivity> MdlH5pactivities { get; set; }

    public virtual DbSet<MdlH5pactivityAttempt> MdlH5pactivityAttempts { get; set; }

    public virtual DbSet<MdlH5pactivityAttemptsResult> MdlH5pactivityAttemptsResults { get; set; }

    public virtual DbSet<MdlImscp> MdlImscps { get; set; }

    public virtual DbSet<MdlInfectedFile> MdlInfectedFiles { get; set; }

    public virtual DbSet<MdlLabel> MdlLabels { get; set; }

    public virtual DbSet<MdlLesson> MdlLessons { get; set; }

    public virtual DbSet<MdlLessonAnswer> MdlLessonAnswers { get; set; }

    public virtual DbSet<MdlLessonAttempt> MdlLessonAttempts { get; set; }

    public virtual DbSet<MdlLessonBranch> MdlLessonBranches { get; set; }

    public virtual DbSet<MdlLessonGrade> MdlLessonGrades { get; set; }

    public virtual DbSet<MdlLessonOverride> MdlLessonOverrides { get; set; }

    public virtual DbSet<MdlLessonPage> MdlLessonPages { get; set; }

    public virtual DbSet<MdlLessonTimer> MdlLessonTimers { get; set; }

    public virtual DbSet<MdlLicense> MdlLicenses { get; set; }

    public virtual DbSet<MdlLockDb> MdlLockDbs { get; set; }

    public virtual DbSet<MdlLog> MdlLogs { get; set; }

    public virtual DbSet<MdlLogDisplay> MdlLogDisplays { get; set; }

    public virtual DbSet<MdlLogQuery> MdlLogQueries { get; set; }

    public virtual DbSet<MdlLogstoreStandardLog> MdlLogstoreStandardLogs { get; set; }

    public virtual DbSet<MdlLti> MdlLtis { get; set; }

    public virtual DbSet<MdlLtiAccessToken> MdlLtiAccessTokens { get; set; }

    public virtual DbSet<MdlLtiSubmission> MdlLtiSubmissions { get; set; }

    public virtual DbSet<MdlLtiToolProxy> MdlLtiToolProxies { get; set; }

    public virtual DbSet<MdlLtiToolSetting> MdlLtiToolSettings { get; set; }

    public virtual DbSet<MdlLtiType> MdlLtiTypes { get; set; }

    public virtual DbSet<MdlLtiTypesConfig> MdlLtiTypesConfigs { get; set; }

    public virtual DbSet<MdlLtiserviceGradebookservice> MdlLtiserviceGradebookservices { get; set; }

    public virtual DbSet<MdlMessage> MdlMessages { get; set; }

    public virtual DbSet<MdlMessage1> MdlMessages1 { get; set; }

    public virtual DbSet<MdlMessageAirnotifierDevice> MdlMessageAirnotifierDevices { get; set; }

    public virtual DbSet<MdlMessageContact> MdlMessageContacts { get; set; }

    public virtual DbSet<MdlMessageContactRequest> MdlMessageContactRequests { get; set; }

    public virtual DbSet<MdlMessageConversation> MdlMessageConversations { get; set; }

    public virtual DbSet<MdlMessageConversationAction> MdlMessageConversationActions { get; set; }

    public virtual DbSet<MdlMessageConversationMember> MdlMessageConversationMembers { get; set; }

    public virtual DbSet<MdlMessageEmailMessage> MdlMessageEmailMessages { get; set; }

    public virtual DbSet<MdlMessagePopup> MdlMessagePopups { get; set; }

    public virtual DbSet<MdlMessagePopupNotification> MdlMessagePopupNotifications { get; set; }

    public virtual DbSet<MdlMessageProcessor> MdlMessageProcessors { get; set; }

    public virtual DbSet<MdlMessageProvider> MdlMessageProviders { get; set; }

    public virtual DbSet<MdlMessageRead> MdlMessageReads { get; set; }

    public virtual DbSet<MdlMessageUserAction> MdlMessageUserActions { get; set; }

    public virtual DbSet<MdlMessageUsersBlocked> MdlMessageUsersBlockeds { get; set; }

    public virtual DbSet<MdlMessageinboundDatakey> MdlMessageinboundDatakeys { get; set; }

    public virtual DbSet<MdlMessageinboundHandler> MdlMessageinboundHandlers { get; set; }

    public virtual DbSet<MdlMessageinboundMessagelist> MdlMessageinboundMessagelists { get; set; }

    public virtual DbSet<MdlMnetApplication> MdlMnetApplications { get; set; }

    public virtual DbSet<MdlMnetHost> MdlMnetHosts { get; set; }

    public virtual DbSet<MdlMnetHost2service> MdlMnetHost2services { get; set; }

    public virtual DbSet<MdlMnetLog> MdlMnetLogs { get; set; }

    public virtual DbSet<MdlMnetRemoteRpc> MdlMnetRemoteRpcs { get; set; }

    public virtual DbSet<MdlMnetRemoteService2rpc> MdlMnetRemoteService2rpcs { get; set; }

    public virtual DbSet<MdlMnetRpc> MdlMnetRpcs { get; set; }

    public virtual DbSet<MdlMnetService> MdlMnetServices { get; set; }

    public virtual DbSet<MdlMnetService2rpc> MdlMnetService2rpcs { get; set; }

    public virtual DbSet<MdlMnetSession> MdlMnetSessions { get; set; }

    public virtual DbSet<MdlMnetSsoAccessControl> MdlMnetSsoAccessControls { get; set; }

    public virtual DbSet<MdlMnetserviceEnrolCourse> MdlMnetserviceEnrolCourses { get; set; }

    public virtual DbSet<MdlMnetserviceEnrolEnrolment> MdlMnetserviceEnrolEnrolments { get; set; }

    public virtual DbSet<MdlModule> MdlModules { get; set; }

    public virtual DbSet<MdlMyPage> MdlMyPages { get; set; }

    public virtual DbSet<MdlNotification> MdlNotifications { get; set; }

    public virtual DbSet<MdlOauth2AccessToken> MdlOauth2AccessTokens { get; set; }

    public virtual DbSet<MdlOauth2Endpoint> MdlOauth2Endpoints { get; set; }

    public virtual DbSet<MdlOauth2Issuer> MdlOauth2Issuers { get; set; }

    public virtual DbSet<MdlOauth2RefreshToken> MdlOauth2RefreshTokens { get; set; }

    public virtual DbSet<MdlOauth2SystemAccount> MdlOauth2SystemAccounts { get; set; }

    public virtual DbSet<MdlOauth2UserFieldMapping> MdlOauth2UserFieldMappings { get; set; }

    public virtual DbSet<MdlPage> MdlPages { get; set; }

    public virtual DbSet<MdlPaygwPaypal> MdlPaygwPaypals { get; set; }

    public virtual DbSet<MdlPayment> MdlPayments { get; set; }

    public virtual DbSet<MdlPaymentAccount> MdlPaymentAccounts { get; set; }

    public virtual DbSet<MdlPaymentGateway> MdlPaymentGateways { get; set; }

    public virtual DbSet<MdlPlagiarismTurnitinConfig> MdlPlagiarismTurnitinConfigs { get; set; }

    public virtual DbSet<MdlPlagiarismTurnitinCourse> MdlPlagiarismTurnitinCourses { get; set; }

    public virtual DbSet<MdlPlagiarismTurnitinFile> MdlPlagiarismTurnitinFiles { get; set; }

    public virtual DbSet<MdlPlagiarismTurnitinPeermark> MdlPlagiarismTurnitinPeermarks { get; set; }

    public virtual DbSet<MdlPlagiarismTurnitinUser> MdlPlagiarismTurnitinUsers { get; set; }

    public virtual DbSet<MdlPortfolioInstance> MdlPortfolioInstances { get; set; }

    public virtual DbSet<MdlPortfolioInstanceConfig> MdlPortfolioInstanceConfigs { get; set; }

    public virtual DbSet<MdlPortfolioInstanceUser> MdlPortfolioInstanceUsers { get; set; }

    public virtual DbSet<MdlPortfolioLog> MdlPortfolioLogs { get; set; }

    public virtual DbSet<MdlPortfolioMaharaQueue> MdlPortfolioMaharaQueues { get; set; }

    public virtual DbSet<MdlPortfolioTempdatum> MdlPortfolioTempdata { get; set; }

    public virtual DbSet<MdlPost> MdlPosts { get; set; }

    public virtual DbSet<MdlProfiling> MdlProfilings { get; set; }

    public virtual DbSet<MdlQtypeDdimageortext> MdlQtypeDdimageortexts { get; set; }

    public virtual DbSet<MdlQtypeDdimageortextDrag> MdlQtypeDdimageortextDrags { get; set; }

    public virtual DbSet<MdlQtypeDdimageortextDrop> MdlQtypeDdimageortextDrops { get; set; }

    public virtual DbSet<MdlQtypeDdmarker> MdlQtypeDdmarkers { get; set; }

    public virtual DbSet<MdlQtypeDdmarkerDrag> MdlQtypeDdmarkerDrags { get; set; }

    public virtual DbSet<MdlQtypeDdmarkerDrop> MdlQtypeDdmarkerDrops { get; set; }

    public virtual DbSet<MdlQtypeEssayOption> MdlQtypeEssayOptions { get; set; }

    public virtual DbSet<MdlQtypeMatchOption> MdlQtypeMatchOptions { get; set; }

    public virtual DbSet<MdlQtypeMatchSubquestion> MdlQtypeMatchSubquestions { get; set; }

    public virtual DbSet<MdlQtypeMultichoiceOption> MdlQtypeMultichoiceOptions { get; set; }

    public virtual DbSet<MdlQtypeRandomsamatchOption> MdlQtypeRandomsamatchOptions { get; set; }

    public virtual DbSet<MdlQtypeShortanswerOption> MdlQtypeShortanswerOptions { get; set; }

    public virtual DbSet<MdlQuestion> MdlQuestions { get; set; }

    public virtual DbSet<MdlQuestionAnswer> MdlQuestionAnswers { get; set; }

    public virtual DbSet<MdlQuestionAttempt> MdlQuestionAttempts { get; set; }

    public virtual DbSet<MdlQuestionAttemptStep> MdlQuestionAttemptSteps { get; set; }

    public virtual DbSet<MdlQuestionAttemptStepDatum> MdlQuestionAttemptStepData { get; set; }

    public virtual DbSet<MdlQuestionCalculated> MdlQuestionCalculateds { get; set; }

    public virtual DbSet<MdlQuestionCalculatedOption> MdlQuestionCalculatedOptions { get; set; }

    public virtual DbSet<MdlQuestionCategory> MdlQuestionCategories { get; set; }

    public virtual DbSet<MdlQuestionDataset> MdlQuestionDatasets { get; set; }

    public virtual DbSet<MdlQuestionDatasetDefinition> MdlQuestionDatasetDefinitions { get; set; }

    public virtual DbSet<MdlQuestionDatasetItem> MdlQuestionDatasetItems { get; set; }

    public virtual DbSet<MdlQuestionDdwto> MdlQuestionDdwtos { get; set; }

    public virtual DbSet<MdlQuestionGapselect> MdlQuestionGapselects { get; set; }

    public virtual DbSet<MdlQuestionHint> MdlQuestionHints { get; set; }

    public virtual DbSet<MdlQuestionMultianswer> MdlQuestionMultianswers { get; set; }

    public virtual DbSet<MdlQuestionNumerical> MdlQuestionNumericals { get; set; }

    public virtual DbSet<MdlQuestionNumericalOption> MdlQuestionNumericalOptions { get; set; }

    public virtual DbSet<MdlQuestionNumericalUnit> MdlQuestionNumericalUnits { get; set; }

    public virtual DbSet<MdlQuestionResponseAnalysis> MdlQuestionResponseAnalyses { get; set; }

    public virtual DbSet<MdlQuestionResponseCount> MdlQuestionResponseCounts { get; set; }

    public virtual DbSet<MdlQuestionStatistic> MdlQuestionStatistics { get; set; }

    public virtual DbSet<MdlQuestionTruefalse> MdlQuestionTruefalses { get; set; }

    public virtual DbSet<MdlQuestionUsage> MdlQuestionUsages { get; set; }

    public virtual DbSet<MdlQuiz> MdlQuizzes { get; set; }

    public virtual DbSet<MdlQuizAttempt> MdlQuizAttempts { get; set; }

    public virtual DbSet<MdlQuizFeedback> MdlQuizFeedbacks { get; set; }

    public virtual DbSet<MdlQuizGrade> MdlQuizGrades { get; set; }

    public virtual DbSet<MdlQuizOverride> MdlQuizOverrides { get; set; }

    public virtual DbSet<MdlQuizOverviewRegrade> MdlQuizOverviewRegrades { get; set; }

    public virtual DbSet<MdlQuizReport> MdlQuizReports { get; set; }

    public virtual DbSet<MdlQuizSection> MdlQuizSections { get; set; }

    public virtual DbSet<MdlQuizSlot> MdlQuizSlots { get; set; }

    public virtual DbSet<MdlQuizSlotTag> MdlQuizSlotTags { get; set; }

    public virtual DbSet<MdlQuizStatistic> MdlQuizStatistics { get; set; }

    public virtual DbSet<MdlQuizaccessSebQuizsetting> MdlQuizaccessSebQuizsettings { get; set; }

    public virtual DbSet<MdlQuizaccessSebTemplate> MdlQuizaccessSebTemplates { get; set; }

    public virtual DbSet<MdlRating> MdlRatings { get; set; }

    public virtual DbSet<MdlRegistrationHub> MdlRegistrationHubs { get; set; }

    public virtual DbSet<MdlRepository> MdlRepositories { get; set; }

    public virtual DbSet<MdlRepositoryInstance> MdlRepositoryInstances { get; set; }

    public virtual DbSet<MdlRepositoryInstanceConfig> MdlRepositoryInstanceConfigs { get; set; }

    public virtual DbSet<MdlRepositoryOnedriveAccess> MdlRepositoryOnedriveAccesses { get; set; }

    public virtual DbSet<MdlResource> MdlResources { get; set; }

    public virtual DbSet<MdlResourceOld> MdlResourceOlds { get; set; }

    public virtual DbSet<MdlRole> MdlRoles { get; set; }

    public virtual DbSet<MdlRoleAllowAssign> MdlRoleAllowAssigns { get; set; }

    public virtual DbSet<MdlRoleAllowOverride> MdlRoleAllowOverrides { get; set; }

    public virtual DbSet<MdlRoleAllowSwitch> MdlRoleAllowSwitches { get; set; }

    public virtual DbSet<MdlRoleAllowView> MdlRoleAllowViews { get; set; }

    public virtual DbSet<MdlRoleAssignment> MdlRoleAssignments { get; set; }

    public virtual DbSet<MdlRoleCapability> MdlRoleCapabilities { get; set; }

    public virtual DbSet<MdlRoleContextLevel> MdlRoleContextLevels { get; set; }

    public virtual DbSet<MdlRoleName> MdlRoleNames { get; set; }

    public virtual DbSet<MdlScale> MdlScales { get; set; }

    public virtual DbSet<MdlScaleHistory> MdlScaleHistories { get; set; }

    public virtual DbSet<MdlScorm> MdlScorms { get; set; }

    public virtual DbSet<MdlScormAiccSession> MdlScormAiccSessions { get; set; }

    public virtual DbSet<MdlScormSco> MdlScormScoes { get; set; }

    public virtual DbSet<MdlScormScoesDatum> MdlScormScoesData { get; set; }

    public virtual DbSet<MdlScormScoesTrack> MdlScormScoesTracks { get; set; }

    public virtual DbSet<MdlScormSeqMapinfo> MdlScormSeqMapinfos { get; set; }

    public virtual DbSet<MdlScormSeqObjective> MdlScormSeqObjectives { get; set; }

    public virtual DbSet<MdlScormSeqRolluprule> MdlScormSeqRolluprules { get; set; }

    public virtual DbSet<MdlScormSeqRolluprulecond> MdlScormSeqRollupruleconds { get; set; }

    public virtual DbSet<MdlScormSeqRulecond> MdlScormSeqRuleconds { get; set; }

    public virtual DbSet<MdlScormSeqRulecond1> MdlScormSeqRuleconds1 { get; set; }

    public virtual DbSet<MdlSearchIndexRequest> MdlSearchIndexRequests { get; set; }

    public virtual DbSet<MdlSearchSimpledbIndex> MdlSearchSimpledbIndices { get; set; }

    public virtual DbSet<MdlSession> MdlSessions { get; set; }

    public virtual DbSet<MdlStatsDaily> MdlStatsDailies { get; set; }

    public virtual DbSet<MdlStatsMonthly> MdlStatsMonthlies { get; set; }

    public virtual DbSet<MdlStatsUserDaily> MdlStatsUserDailies { get; set; }

    public virtual DbSet<MdlStatsUserMonthly> MdlStatsUserMonthlies { get; set; }

    public virtual DbSet<MdlStatsUserWeekly> MdlStatsUserWeeklies { get; set; }

    public virtual DbSet<MdlStatsWeekly> MdlStatsWeeklies { get; set; }

    public virtual DbSet<MdlSurvey> MdlSurveys { get; set; }

    public virtual DbSet<MdlSurveyAnalysis> MdlSurveyAnalyses { get; set; }

    public virtual DbSet<MdlSurveyAnswer> MdlSurveyAnswers { get; set; }

    public virtual DbSet<MdlSurveyQuestion> MdlSurveyQuestions { get; set; }

    public virtual DbSet<MdlTag> MdlTags { get; set; }

    public virtual DbSet<MdlTagArea> MdlTagAreas { get; set; }

    public virtual DbSet<MdlTagColl> MdlTagColls { get; set; }

    public virtual DbSet<MdlTagCorrelation> MdlTagCorrelations { get; set; }

    public virtual DbSet<MdlTagInstance> MdlTagInstances { get; set; }

    public virtual DbSet<MdlTaskAdhoc> MdlTaskAdhocs { get; set; }

    public virtual DbSet<MdlTaskLog> MdlTaskLogs { get; set; }

    public virtual DbSet<MdlTaskScheduled> MdlTaskScheduleds { get; set; }

    public virtual DbSet<MdlToolBrickfieldArea> MdlToolBrickfieldAreas { get; set; }

    public virtual DbSet<MdlToolBrickfieldCacheAct> MdlToolBrickfieldCacheActs { get; set; }

    public virtual DbSet<MdlToolBrickfieldCacheCheck> MdlToolBrickfieldCacheChecks { get; set; }

    public virtual DbSet<MdlToolBrickfieldCheck> MdlToolBrickfieldChecks { get; set; }

    public virtual DbSet<MdlToolBrickfieldContent> MdlToolBrickfieldContents { get; set; }

    public virtual DbSet<MdlToolBrickfieldError> MdlToolBrickfieldErrors { get; set; }

    public virtual DbSet<MdlToolBrickfieldProcess> MdlToolBrickfieldProcesses { get; set; }

    public virtual DbSet<MdlToolBrickfieldResult> MdlToolBrickfieldResults { get; set; }

    public virtual DbSet<MdlToolBrickfieldSchedule> MdlToolBrickfieldSchedules { get; set; }

    public virtual DbSet<MdlToolBrickfieldSummary> MdlToolBrickfieldSummaries { get; set; }

    public virtual DbSet<MdlToolCohortrole> MdlToolCohortroles { get; set; }

    public virtual DbSet<MdlToolCustomlang> MdlToolCustomlangs { get; set; }

    public virtual DbSet<MdlToolCustomlangComponent> MdlToolCustomlangComponents { get; set; }

    public virtual DbSet<MdlToolDataprivacyCategory> MdlToolDataprivacyCategories { get; set; }

    public virtual DbSet<MdlToolDataprivacyCtxexpired> MdlToolDataprivacyCtxexpireds { get; set; }

    public virtual DbSet<MdlToolDataprivacyCtxinstance> MdlToolDataprivacyCtxinstances { get; set; }

    public virtual DbSet<MdlToolDataprivacyCtxlevel> MdlToolDataprivacyCtxlevels { get; set; }

    public virtual DbSet<MdlToolDataprivacyPurpose> MdlToolDataprivacyPurposes { get; set; }

    public virtual DbSet<MdlToolDataprivacyPurposerole> MdlToolDataprivacyPurposeroles { get; set; }

    public virtual DbSet<MdlToolDataprivacyRequest> MdlToolDataprivacyRequests { get; set; }

    public virtual DbSet<MdlToolMonitorEvent> MdlToolMonitorEvents { get; set; }

    public virtual DbSet<MdlToolMonitorHistory> MdlToolMonitorHistories { get; set; }

    public virtual DbSet<MdlToolMonitorRule> MdlToolMonitorRules { get; set; }

    public virtual DbSet<MdlToolMonitorSubscription> MdlToolMonitorSubscriptions { get; set; }

    public virtual DbSet<MdlToolPolicy> MdlToolPolicies { get; set; }

    public virtual DbSet<MdlToolPolicyAcceptance> MdlToolPolicyAcceptances { get; set; }

    public virtual DbSet<MdlToolPolicyVersion> MdlToolPolicyVersions { get; set; }

    public virtual DbSet<MdlToolRecyclebinCategory> MdlToolRecyclebinCategories { get; set; }

    public virtual DbSet<MdlToolRecyclebinCourse> MdlToolRecyclebinCourses { get; set; }

    public virtual DbSet<MdlToolUsertoursStep> MdlToolUsertoursSteps { get; set; }

    public virtual DbSet<MdlToolUsertoursTour> MdlToolUsertoursTours { get; set; }

    public virtual DbSet<MdlUpgradeLog> MdlUpgradeLogs { get; set; }

    public virtual DbSet<MdlUrl> MdlUrls { get; set; }

    public virtual DbSet<MdlUser> MdlUsers { get; set; }

    public virtual DbSet<MdlUserDevice> MdlUserDevices { get; set; }

    public virtual DbSet<MdlUserEnrolment> MdlUserEnrolments { get; set; }

    public virtual DbSet<MdlUserInfoCategory> MdlUserInfoCategories { get; set; }

    public virtual DbSet<MdlUserInfoDatum> MdlUserInfoData { get; set; }

    public virtual DbSet<MdlUserInfoField> MdlUserInfoFields { get; set; }

    public virtual DbSet<MdlUserLastaccess> MdlUserLastaccesses { get; set; }

    public virtual DbSet<MdlUserPasswordHistory> MdlUserPasswordHistories { get; set; }

    public virtual DbSet<MdlUserPasswordReset> MdlUserPasswordResets { get; set; }

    public virtual DbSet<MdlUserPreference> MdlUserPreferences { get; set; }

    public virtual DbSet<MdlUserPrivateKey> MdlUserPrivateKeys { get; set; }

    public virtual DbSet<MdlWiki> MdlWikis { get; set; }

    public virtual DbSet<MdlWikiLink> MdlWikiLinks { get; set; }

    public virtual DbSet<MdlWikiLock> MdlWikiLocks { get; set; }

    public virtual DbSet<MdlWikiPage> MdlWikiPages { get; set; }

    public virtual DbSet<MdlWikiSubwiki> MdlWikiSubwikis { get; set; }

    public virtual DbSet<MdlWikiSynonym> MdlWikiSynonyms { get; set; }

    public virtual DbSet<MdlWikiVersion> MdlWikiVersions { get; set; }

    public virtual DbSet<MdlWorkshop> MdlWorkshops { get; set; }

    public virtual DbSet<MdlWorkshopAggregation> MdlWorkshopAggregations { get; set; }

    public virtual DbSet<MdlWorkshopAssessment> MdlWorkshopAssessments { get; set; }

    public virtual DbSet<MdlWorkshopGrade> MdlWorkshopGrades { get; set; }

    public virtual DbSet<MdlWorkshopSubmission> MdlWorkshopSubmissions { get; set; }

    public virtual DbSet<MdlWorkshopallocationScheduled> MdlWorkshopallocationScheduleds { get; set; }

    public virtual DbSet<MdlWorkshopevalBestSetting> MdlWorkshopevalBestSettings { get; set; }

    public virtual DbSet<MdlWorkshopformAccumulative> MdlWorkshopformAccumulatives { get; set; }

    public virtual DbSet<MdlWorkshopformComment> MdlWorkshopformComments { get; set; }

    public virtual DbSet<MdlWorkshopformNumerror> MdlWorkshopformNumerrors { get; set; }

    public virtual DbSet<MdlWorkshopformNumerrorsMap> MdlWorkshopformNumerrorsMaps { get; set; }

    public virtual DbSet<MdlWorkshopformRubric> MdlWorkshopformRubrics { get; set; }

    public virtual DbSet<MdlWorkshopformRubricConfig> MdlWorkshopformRubricConfigs { get; set; }

    public virtual DbSet<MdlWorkshopformRubricLevel> MdlWorkshopformRubricLevels { get; set; }

    public virtual DbSet<MdlZoom> MdlZooms { get; set; }

    public virtual DbSet<MdlZoomBreakoutGroup> MdlZoomBreakoutGroups { get; set; }

    public virtual DbSet<MdlZoomBreakoutParticipant> MdlZoomBreakoutParticipants { get; set; }

    public virtual DbSet<MdlZoomMeetingBreakoutRoom> MdlZoomMeetingBreakoutRooms { get; set; }

    public virtual DbSet<MdlZoomMeetingDetail> MdlZoomMeetingDetails { get; set; }

    public virtual DbSet<MdlZoomMeetingParticipant> MdlZoomMeetingParticipants { get; set; }

    public virtual DbSet<MdlZoomMeetingRecording> MdlZoomMeetingRecordings { get; set; }

    public virtual DbSet<MdlZoomMeetingRecordingsView> MdlZoomMeetingRecordingsViews { get; set; }

    public virtual DbSet<MdlZoomMeetingTrackingField> MdlZoomMeetingTrackingFields { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=MOODLE;user=root;password=2805", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.37-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<MdlAnalyticsIndicatorCalc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_analytics_indicator_calc", tb => tb.HasComment("Stored indicator calculations"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_analindicalc_con_ix");

            entity.HasIndex(e => new { e.Starttime, e.Endtime, e.Contextid }, "mdl_analindicalc_staendcon_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Endtime).HasColumnName("endtime");
            entity.Property(e => e.Indicator)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("indicator");
            entity.Property(e => e.Sampleid).HasColumnName("sampleid");
            entity.Property(e => e.Sampleorigin)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("sampleorigin");
            entity.Property(e => e.Starttime).HasColumnName("starttime");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Value)
                .HasPrecision(10, 2)
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlAnalyticsModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_analytics_models", tb => tb.HasComment("Analytic models."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Enabled, e.Trained }, "mdl_analmode_enatra_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextids).HasColumnName("contextids");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Indicators).HasColumnName("indicators");
            entity.Property(e => e.Name)
                .HasMaxLength(1333)
                .HasColumnName("name");
            entity.Property(e => e.Predictionsprocessor)
                .HasMaxLength(255)
                .HasColumnName("predictionsprocessor");
            entity.Property(e => e.Target)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("target");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timesplitting)
                .HasMaxLength(255)
                .HasColumnName("timesplitting");
            entity.Property(e => e.Trained).HasColumnName("trained");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<MdlAnalyticsModelsLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_analytics_models_log", tb => tb.HasComment("Analytic models changes during evaluation."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Modelid, "mdl_analmodelog_mod_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dir).HasColumnName("dir");
            entity.Property(e => e.Evaluationmode)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("evaluationmode");
            entity.Property(e => e.Indicators).HasColumnName("indicators");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Modelid).HasColumnName("modelid");
            entity.Property(e => e.Score)
                .HasPrecision(10, 5)
                .HasColumnName("score");
            entity.Property(e => e.Target)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("target");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timesplitting)
                .HasMaxLength(255)
                .HasColumnName("timesplitting");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<MdlAnalyticsPredictSample>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_analytics_predict_samples", tb => tb.HasComment("Samples already used for predictions."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Modelid, "mdl_analpredsamp_mod_ix");

            entity.HasIndex(e => new { e.Modelid, e.Analysableid, e.Timesplitting, e.Rangeindex }, "mdl_analpredsamp_modanatimr_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Analysableid).HasColumnName("analysableid");
            entity.Property(e => e.Modelid).HasColumnName("modelid");
            entity.Property(e => e.Rangeindex).HasColumnName("rangeindex");
            entity.Property(e => e.Sampleids).HasColumnName("sampleids");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timesplitting)
                .HasDefaultValueSql("''")
                .HasColumnName("timesplitting");
        });

        modelBuilder.Entity<MdlAnalyticsPrediction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_analytics_predictions", tb => tb.HasComment("Predictions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_analpred_con_ix");

            entity.HasIndex(e => e.Modelid, "mdl_analpred_mod_ix");

            entity.HasIndex(e => new { e.Modelid, e.Contextid }, "mdl_analpred_modcon_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calculations).HasColumnName("calculations");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Modelid).HasColumnName("modelid");
            entity.Property(e => e.Prediction)
                .HasPrecision(10, 2)
                .HasColumnName("prediction");
            entity.Property(e => e.Predictionscore)
                .HasPrecision(10, 5)
                .HasColumnName("predictionscore");
            entity.Property(e => e.Rangeindex)
                .HasColumnType("mediumint")
                .HasColumnName("rangeindex");
            entity.Property(e => e.Sampleid).HasColumnName("sampleid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timeend).HasColumnName("timeend");
            entity.Property(e => e.Timestart).HasColumnName("timestart");
        });

        modelBuilder.Entity<MdlAnalyticsPredictionAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_analytics_prediction_actions", tb => tb.HasComment("Register of user actions over predictions."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Predictionid, "mdl_analpredacti_pre_ix");

            entity.HasIndex(e => new { e.Predictionid, e.Userid, e.Actionname }, "mdl_analpredacti_preuseact_ix");

            entity.HasIndex(e => e.Userid, "mdl_analpredacti_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Actionname)
                .HasDefaultValueSql("''")
                .HasColumnName("actionname");
            entity.Property(e => e.Predictionid).HasColumnName("predictionid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAnalyticsTrainSample>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_analytics_train_samples", tb => tb.HasComment("Samples used for training"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Modelid, "mdl_analtraisamp_mod_ix");

            entity.HasIndex(e => new { e.Modelid, e.Analysableid, e.Timesplitting }, "mdl_analtraisamp_modanatim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Analysableid).HasColumnName("analysableid");
            entity.Property(e => e.Modelid).HasColumnName("modelid");
            entity.Property(e => e.Sampleids).HasColumnName("sampleids");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timesplitting)
                .HasDefaultValueSql("''")
                .HasColumnName("timesplitting");
        });

        modelBuilder.Entity<MdlAnalyticsUsedAnalysable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_analytics_used_analysables", tb => tb.HasComment("List of analysables used by each model"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Analysableid, "mdl_analusedanal_ana_ix");

            entity.HasIndex(e => e.Modelid, "mdl_analusedanal_mod_ix");

            entity.HasIndex(e => new { e.Modelid, e.Action }, "mdl_analusedanal_modact_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Analysableid).HasColumnName("analysableid");
            entity.Property(e => e.Firstanalysis).HasColumnName("firstanalysis");
            entity.Property(e => e.Modelid).HasColumnName("modelid");
            entity.Property(e => e.Timeanalysed).HasColumnName("timeanalysed");
        });

        modelBuilder.Entity<MdlAnalyticsUsedFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_analytics_used_files", tb => tb.HasComment("Files that have already been used for training and predictio"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Fileid, "mdl_analusedfile_fil_ix");

            entity.HasIndex(e => e.Modelid, "mdl_analusedfile_mod_ix");

            entity.HasIndex(e => new { e.Modelid, e.Action, e.Fileid }, "mdl_analusedfile_modactfil_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Fileid).HasColumnName("fileid");
            entity.Property(e => e.Modelid).HasColumnName("modelid");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<MdlAssign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assign", tb => tb.HasComment("This table saves information about an instance of mod_assign"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_assi_cou_ix");

            entity.HasIndex(e => e.Teamsubmissiongroupingid, "mdl_assi_tea_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allowsubmissionsfromdate).HasColumnName("allowsubmissionsfromdate");
            entity.Property(e => e.Alwaysshowdescription).HasColumnName("alwaysshowdescription");
            entity.Property(e => e.Attemptreopenmethod)
                .HasMaxLength(10)
                .HasDefaultValueSql("'none'")
                .HasColumnName("attemptreopenmethod");
            entity.Property(e => e.Blindmarking).HasColumnName("blindmarking");
            entity.Property(e => e.Completionsubmit).HasColumnName("completionsubmit");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Cutoffdate).HasColumnName("cutoffdate");
            entity.Property(e => e.Duedate).HasColumnName("duedate");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Gradingduedate).HasColumnName("gradingduedate");
            entity.Property(e => e.Hidegrader).HasColumnName("hidegrader");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Markingallocation).HasColumnName("markingallocation");
            entity.Property(e => e.Markingworkflow).HasColumnName("markingworkflow");
            entity.Property(e => e.Maxattempts)
                .HasDefaultValueSql("'-1'")
                .HasColumnType("mediumint")
                .HasColumnName("maxattempts");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Nosubmissions).HasColumnName("nosubmissions");
            entity.Property(e => e.Preventsubmissionnotingroup).HasColumnName("preventsubmissionnotingroup");
            entity.Property(e => e.Requireallteammemberssubmit).HasColumnName("requireallteammemberssubmit");
            entity.Property(e => e.Requiresubmissionstatement).HasColumnName("requiresubmissionstatement");
            entity.Property(e => e.Revealidentities).HasColumnName("revealidentities");
            entity.Property(e => e.Sendlatenotifications).HasColumnName("sendlatenotifications");
            entity.Property(e => e.Sendnotifications).HasColumnName("sendnotifications");
            entity.Property(e => e.Sendstudentnotifications)
                .HasDefaultValueSql("'1'")
                .HasColumnName("sendstudentnotifications");
            entity.Property(e => e.Submissiondrafts).HasColumnName("submissiondrafts");
            entity.Property(e => e.Teamsubmission).HasColumnName("teamsubmission");
            entity.Property(e => e.Teamsubmissiongroupingid).HasColumnName("teamsubmissiongroupingid");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlAssignGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assign_grades", tb => tb.HasComment("Grading information about a single assignment submission."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Assignment, "mdl_assigrad_ass_ix");

            entity.HasIndex(e => new { e.Assignment, e.Userid, e.Attemptnumber }, "mdl_assigrad_assuseatt_uix").IsUnique();

            entity.HasIndex(e => e.Attemptnumber, "mdl_assigrad_att_ix");

            entity.HasIndex(e => e.Userid, "mdl_assigrad_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assignment).HasColumnName("assignment");
            entity.Property(e => e.Attemptnumber).HasColumnName("attemptnumber");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'0.00000'")
                .HasColumnName("grade");
            entity.Property(e => e.Grader).HasColumnName("grader");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAssignOverride>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assign_overrides", tb => tb.HasComment("The overrides to assign settings."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Assignid, "mdl_assiover_ass_ix");

            entity.HasIndex(e => e.Groupid, "mdl_assiover_gro_ix");

            entity.HasIndex(e => e.Userid, "mdl_assiover_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allowsubmissionsfromdate).HasColumnName("allowsubmissionsfromdate");
            entity.Property(e => e.Assignid).HasColumnName("assignid");
            entity.Property(e => e.Cutoffdate).HasColumnName("cutoffdate");
            entity.Property(e => e.Duedate).HasColumnName("duedate");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAssignPluginConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assign_plugin_config", tb => tb.HasComment("Config data for an instance of a plugin in an assignment."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Assignment, "mdl_assiplugconf_ass_ix");

            entity.HasIndex(e => e.Name, "mdl_assiplugconf_nam_ix");

            entity.HasIndex(e => e.Plugin, "mdl_assiplugconf_plu_ix");

            entity.HasIndex(e => e.Subtype, "mdl_assiplugconf_sub_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assignment).HasColumnName("assignment");
            entity.Property(e => e.Name)
                .HasMaxLength(28)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Plugin)
                .HasMaxLength(28)
                .HasDefaultValueSql("''")
                .HasColumnName("plugin");
            entity.Property(e => e.Subtype)
                .HasMaxLength(28)
                .HasDefaultValueSql("''")
                .HasColumnName("subtype");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlAssignSubmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assign_submission", tb => tb.HasComment("This table keeps information about student interactions with"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Assignment, "mdl_assisubm_ass_ix");

            entity.HasIndex(e => new { e.Assignment, e.Userid, e.Groupid, e.Attemptnumber }, "mdl_assisubm_assusegroatt_uix").IsUnique();

            entity.HasIndex(e => new { e.Assignment, e.Userid, e.Groupid, e.Latest }, "mdl_assisubm_assusegrolat_ix");

            entity.HasIndex(e => e.Attemptnumber, "mdl_assisubm_att_ix");

            entity.HasIndex(e => e.Userid, "mdl_assisubm_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assignment).HasColumnName("assignment");
            entity.Property(e => e.Attemptnumber).HasColumnName("attemptnumber");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Latest).HasColumnName("latest");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAssignUserFlag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assign_user_flags", tb => tb.HasComment("List of flags that can be set for a single user in a single "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Assignment, "mdl_assiuserflag_ass_ix");

            entity.HasIndex(e => e.Mailed, "mdl_assiuserflag_mai_ix");

            entity.HasIndex(e => e.Userid, "mdl_assiuserflag_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allocatedmarker).HasColumnName("allocatedmarker");
            entity.Property(e => e.Assignment).HasColumnName("assignment");
            entity.Property(e => e.Extensionduedate).HasColumnName("extensionduedate");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Mailed).HasColumnName("mailed");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Workflowstate)
                .HasMaxLength(20)
                .HasColumnName("workflowstate");
        });

        modelBuilder.Entity<MdlAssignUserMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assign_user_mapping", tb => tb.HasComment("Map an assignment specific id number to a user"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Assignment, "mdl_assiusermapp_ass_ix");

            entity.HasIndex(e => e.Userid, "mdl_assiusermapp_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assignment).HasColumnName("assignment");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAssignfeedbackComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assignfeedback_comments", tb => tb.HasComment("Text feedback for submitted assignments"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Assignment, "mdl_assicomm_ass_ix");

            entity.HasIndex(e => e.Grade, "mdl_assicomm_gra_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assignment).HasColumnName("assignment");
            entity.Property(e => e.Commentformat).HasColumnName("commentformat");
            entity.Property(e => e.Commenttext).HasColumnName("commenttext");
            entity.Property(e => e.Grade).HasColumnName("grade");
        });

        modelBuilder.Entity<MdlAssignfeedbackEditpdfAnnot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assignfeedback_editpdf_annot", tb => tb.HasComment("stores annotations added to pdfs submitted by students"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Gradeid, "mdl_assieditanno_gra_ix");

            entity.HasIndex(e => new { e.Gradeid, e.Pageno }, "mdl_assieditanno_grapag_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Colour)
                .HasMaxLength(10)
                .HasDefaultValueSql("'black'")
                .HasColumnName("colour");
            entity.Property(e => e.Draft)
                .HasDefaultValueSql("'1'")
                .HasColumnName("draft");
            entity.Property(e => e.Endx)
                .HasDefaultValueSql("'0'")
                .HasColumnName("endx");
            entity.Property(e => e.Endy)
                .HasDefaultValueSql("'0'")
                .HasColumnName("endy");
            entity.Property(e => e.Gradeid).HasColumnName("gradeid");
            entity.Property(e => e.Pageno).HasColumnName("pageno");
            entity.Property(e => e.Path).HasColumnName("path");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasDefaultValueSql("'line'")
                .HasColumnName("type");
            entity.Property(e => e.X)
                .HasDefaultValueSql("'0'")
                .HasColumnName("x");
            entity.Property(e => e.Y)
                .HasDefaultValueSql("'0'")
                .HasColumnName("y");
        });

        modelBuilder.Entity<MdlAssignfeedbackEditpdfCmnt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assignfeedback_editpdf_cmnt", tb => tb.HasComment("Stores comments added to pdfs"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Gradeid, "mdl_assieditcmnt_gra_ix");

            entity.HasIndex(e => new { e.Gradeid, e.Pageno }, "mdl_assieditcmnt_grapag_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Colour)
                .HasMaxLength(10)
                .HasDefaultValueSql("'black'")
                .HasColumnName("colour");
            entity.Property(e => e.Draft)
                .HasDefaultValueSql("'1'")
                .HasColumnName("draft");
            entity.Property(e => e.Gradeid).HasColumnName("gradeid");
            entity.Property(e => e.Pageno).HasColumnName("pageno");
            entity.Property(e => e.Rawtext).HasColumnName("rawtext");
            entity.Property(e => e.Width)
                .HasDefaultValueSql("'120'")
                .HasColumnName("width");
            entity.Property(e => e.X)
                .HasDefaultValueSql("'0'")
                .HasColumnName("x");
            entity.Property(e => e.Y)
                .HasDefaultValueSql("'0'")
                .HasColumnName("y");
        });

        modelBuilder.Entity<MdlAssignfeedbackEditpdfQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assignfeedback_editpdf_queue", tb => tb.HasComment("Queue for processing."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Submissionid, e.Submissionattempt }, "mdl_assieditqueu_subsub_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attemptedconversions).HasColumnName("attemptedconversions");
            entity.Property(e => e.Submissionattempt).HasColumnName("submissionattempt");
            entity.Property(e => e.Submissionid).HasColumnName("submissionid");
        });

        modelBuilder.Entity<MdlAssignfeedbackEditpdfQuick>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assignfeedback_editpdf_quick", tb => tb.HasComment("Stores teacher specified quicklist comments"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Userid, "mdl_assieditquic_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Colour)
                .HasMaxLength(10)
                .HasDefaultValueSql("'yellow'")
                .HasColumnName("colour");
            entity.Property(e => e.Rawtext).HasColumnName("rawtext");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Width)
                .HasDefaultValueSql("'120'")
                .HasColumnName("width");
        });

        modelBuilder.Entity<MdlAssignfeedbackEditpdfRot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assignfeedback_editpdf_rot")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Gradeid, "mdl_assieditrot_gra_ix");

            entity.HasIndex(e => new { e.Gradeid, e.Pageno }, "mdl_assieditrot_grapag_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Degree).HasColumnName("degree");
            entity.Property(e => e.Gradeid).HasColumnName("gradeid");
            entity.Property(e => e.Isrotated).HasColumnName("isrotated");
            entity.Property(e => e.Pageno).HasColumnName("pageno");
            entity.Property(e => e.Pathnamehash).HasColumnName("pathnamehash");
        });

        modelBuilder.Entity<MdlAssignfeedbackFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assignfeedback_file", tb => tb.HasComment("Stores info about the number of files submitted by a student"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Assignment, "mdl_assifile_ass2_ix");

            entity.HasIndex(e => e.Grade, "mdl_assifile_gra_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assignment).HasColumnName("assignment");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Numfiles).HasColumnName("numfiles");
        });

        modelBuilder.Entity<MdlAssignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assignment", tb => tb.HasComment("Defines assignments"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_assi_cou2_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assignmenttype)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("assignmenttype");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Emailteachers).HasColumnName("emailteachers");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Maxbytes)
                .HasDefaultValueSql("'100000'")
                .HasColumnName("maxbytes");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Preventlate).HasColumnName("preventlate");
            entity.Property(e => e.Resubmit).HasColumnName("resubmit");
            entity.Property(e => e.Timeavailable).HasColumnName("timeavailable");
            entity.Property(e => e.Timedue).HasColumnName("timedue");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Var1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("var1");
            entity.Property(e => e.Var2)
                .HasDefaultValueSql("'0'")
                .HasColumnName("var2");
            entity.Property(e => e.Var3)
                .HasDefaultValueSql("'0'")
                .HasColumnName("var3");
            entity.Property(e => e.Var4)
                .HasDefaultValueSql("'0'")
                .HasColumnName("var4");
            entity.Property(e => e.Var5)
                .HasDefaultValueSql("'0'")
                .HasColumnName("var5");
        });

        modelBuilder.Entity<MdlAssignmentSubmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assignment_submissions", tb => tb.HasComment("Info about submitted assignments"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Assignment, "mdl_assisubm_ass2_ix");

            entity.HasIndex(e => e.Mailed, "mdl_assisubm_mai_ix");

            entity.HasIndex(e => e.Timemarked, "mdl_assisubm_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_assisubm_use2_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assignment).HasColumnName("assignment");
            entity.Property(e => e.Data1).HasColumnName("data1");
            entity.Property(e => e.Data2).HasColumnName("data2");
            entity.Property(e => e.Format).HasColumnName("format");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Mailed).HasColumnName("mailed");
            entity.Property(e => e.Numfiles).HasColumnName("numfiles");
            entity.Property(e => e.Submissioncomment).HasColumnName("submissioncomment");
            entity.Property(e => e.Teacher).HasColumnName("teacher");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemarked).HasColumnName("timemarked");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAssignmentUpgrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assignment_upgrade", tb => tb.HasComment("Info about upgraded assignments"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Oldinstance, "mdl_assiupgr_old2_ix");

            entity.HasIndex(e => e.Oldcmid, "mdl_assiupgr_old_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Newcmid).HasColumnName("newcmid");
            entity.Property(e => e.Newinstance).HasColumnName("newinstance");
            entity.Property(e => e.Oldcmid).HasColumnName("oldcmid");
            entity.Property(e => e.Oldinstance).HasColumnName("oldinstance");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlAssignsubmissionFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assignsubmission_file", tb => tb.HasComment("Info about file submissions for assignments"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Assignment, "mdl_assifile_ass_ix");

            entity.HasIndex(e => e.Submission, "mdl_assifile_sub_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assignment).HasColumnName("assignment");
            entity.Property(e => e.Numfiles).HasColumnName("numfiles");
            entity.Property(e => e.Submission).HasColumnName("submission");
        });

        modelBuilder.Entity<MdlAssignsubmissionOnlinetext>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_assignsubmission_onlinetext", tb => tb.HasComment("Info about onlinetext submission"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Assignment, "mdl_assionli_ass_ix");

            entity.HasIndex(e => e.Submission, "mdl_assionli_sub_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assignment).HasColumnName("assignment");
            entity.Property(e => e.Onlineformat).HasColumnName("onlineformat");
            entity.Property(e => e.Onlinetext).HasColumnName("onlinetext");
            entity.Property(e => e.Submission).HasColumnName("submission");
        });

        modelBuilder.Entity<MdlAttendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_attendance", tb => tb.HasComment("Attendance module table"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_atte_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Grade)
                .HasDefaultValueSql("'100'")
                .HasColumnName("grade");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Sessiondetailspos)
                .HasMaxLength(5)
                .HasDefaultValueSql("'left'")
                .HasColumnName("sessiondetailspos");
            entity.Property(e => e.Showextrauserdetails)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("showextrauserdetails");
            entity.Property(e => e.Showsessiondetails)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("showsessiondetails");
            entity.Property(e => e.Subnet)
                .HasMaxLength(255)
                .HasColumnName("subnet");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlAttendanceLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_attendance_log", tb => tb.HasComment("attendance_log table retrofitted from MySQL"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Sessionid, "mdl_attelog_ses_ix");

            entity.HasIndex(e => e.Statusid, "mdl_attelog_sta_ix");

            entity.HasIndex(e => e.Studentid, "mdl_attelog_stu_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(45)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Remarks)
                .HasMaxLength(255)
                .HasColumnName("remarks");
            entity.Property(e => e.Sessionid).HasColumnName("sessionid");
            entity.Property(e => e.Statusid).HasColumnName("statusid");
            entity.Property(e => e.Statusset)
                .HasMaxLength(1333)
                .HasColumnName("statusset");
            entity.Property(e => e.Studentid).HasColumnName("studentid");
            entity.Property(e => e.Takenby).HasColumnName("takenby");
            entity.Property(e => e.Timetaken).HasColumnName("timetaken");
        });

        modelBuilder.Entity<MdlAttendanceRotatePassword>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_attendance_rotate_passwords")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attendanceid).HasColumnName("attendanceid");
            entity.Property(e => e.Expirytime).HasColumnName("expirytime");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("password");
        });

        modelBuilder.Entity<MdlAttendanceSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_attendance_sessions", tb => tb.HasComment("attendance_sessions table"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Attendanceid, "mdl_attesess_att_ix");

            entity.HasIndex(e => e.Caleventid, "mdl_attesess_cal_ix");

            entity.HasIndex(e => e.Groupid, "mdl_attesess_gro_ix");

            entity.HasIndex(e => e.Sessdate, "mdl_attesess_ses_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Absenteereport)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("absenteereport");
            entity.Property(e => e.Attendanceid).HasColumnName("attendanceid");
            entity.Property(e => e.Autoassignstatus).HasColumnName("autoassignstatus");
            entity.Property(e => e.Automark).HasColumnName("automark");
            entity.Property(e => e.Automarkcompleted).HasColumnName("automarkcompleted");
            entity.Property(e => e.Calendarevent)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("calendarevent");
            entity.Property(e => e.Caleventid).HasColumnName("caleventid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Includeqrcode).HasColumnName("includeqrcode");
            entity.Property(e => e.Lasttaken).HasColumnName("lasttaken");
            entity.Property(e => e.Lasttakenby).HasColumnName("lasttakenby");
            entity.Property(e => e.Preventsharedip).HasColumnName("preventsharedip");
            entity.Property(e => e.Preventsharediptime).HasColumnName("preventsharediptime");
            entity.Property(e => e.Rotateqrcode).HasColumnName("rotateqrcode");
            entity.Property(e => e.Rotateqrcodesecret)
                .HasMaxLength(10)
                .HasColumnName("rotateqrcodesecret");
            entity.Property(e => e.Sessdate).HasColumnName("sessdate");
            entity.Property(e => e.Statusset)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("statusset");
            entity.Property(e => e.Studentpassword)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("studentpassword");
            entity.Property(e => e.Studentscanmark).HasColumnName("studentscanmark");
            entity.Property(e => e.Subnet)
                .HasMaxLength(255)
                .HasColumnName("subnet");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlAttendanceStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_attendance_statuses", tb => tb.HasComment("attendance_statuses table retrofitted from MySQL"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Attendanceid, "mdl_attestat_att_ix");

            entity.HasIndex(e => e.Deleted, "mdl_attestat_del_ix");

            entity.HasIndex(e => e.Visible, "mdl_attestat_vis_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acronym)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .HasColumnName("acronym");
            entity.Property(e => e.Attendanceid).HasColumnName("attendanceid");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.Grade)
                .HasPrecision(5, 2)
                .HasColumnName("grade");
            entity.Property(e => e.Setnumber)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("setnumber");
            entity.Property(e => e.Setunmarked).HasColumnName("setunmarked");
            entity.Property(e => e.Studentavailability).HasColumnName("studentavailability");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlAttendanceTempuser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_attendance_tempusers", tb => tb.HasComment("Stores temporary users details"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_attetemp_cou_ix");

            entity.HasIndex(e => e.Studentid, "mdl_attetemp_stu_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .HasColumnName("fullname");
            entity.Property(e => e.Studentid).HasColumnName("studentid");
        });

        modelBuilder.Entity<MdlAttendanceWarning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_attendance_warning", tb => tb.HasComment("Warning configuration"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Idnumber, e.Warningpercent, e.Warnafter }, "mdl_attewarn_idnwarwar_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Emailcontent).HasColumnName("emailcontent");
            entity.Property(e => e.Emailcontentformat).HasColumnName("emailcontentformat");
            entity.Property(e => e.Emailsubject)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("emailsubject");
            entity.Property(e => e.Emailuser).HasColumnName("emailuser");
            entity.Property(e => e.Idnumber).HasColumnName("idnumber");
            entity.Property(e => e.Maxwarn)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxwarn");
            entity.Property(e => e.Thirdpartyemails).HasColumnName("thirdpartyemails");
            entity.Property(e => e.Warnafter).HasColumnName("warnafter");
            entity.Property(e => e.Warningpercent).HasColumnName("warningpercent");
        });

        modelBuilder.Entity<MdlAttendanceWarningDone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_attendance_warning_done", tb => tb.HasComment("Warnings processed"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Notifyid, e.Userid }, "mdl_attewarndone_notuse_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Notifyid).HasColumnName("notifyid");
            entity.Property(e => e.Timesent).HasColumnName("timesent");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAuthOauth2LinkedLogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_auth_oauth2_linked_login", tb => tb.HasComment("Accounts linked to a users Moodle account."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Issuerid, "mdl_authoautlinklogi_iss_ix");

            entity.HasIndex(e => new { e.Issuerid, e.Username }, "mdl_authoautlinklogi_issuse_ix");

            entity.HasIndex(e => e.Userid, "mdl_authoautlinklogi_use2_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_authoautlinklogi_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Issuerid, e.Username }, "mdl_authoautlinklogi_useis_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Confirmtoken)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("confirmtoken");
            entity.Property(e => e.Confirmtokenexpires).HasColumnName("confirmtokenexpires");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Issuerid).HasColumnName("issuerid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
            entity.Property(e => e.Username)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<MdlBackupController>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_backup_controllers", tb => tb.HasComment("To store the backup_controllers as they are used"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Backupid, "mdl_backcont_bac_uix").IsUnique();

            entity.HasIndex(e => new { e.Type, e.Itemid }, "mdl_backcont_typite_ix");

            entity.HasIndex(e => e.Userid, "mdl_backcont_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Itemid }, "mdl_backcont_useite_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Backupid)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("backupid");
            entity.Property(e => e.Checksum)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("checksum");
            entity.Property(e => e.Controller).HasColumnName("controller");
            entity.Property(e => e.Execution).HasColumnName("execution");
            entity.Property(e => e.Executiontime).HasColumnName("executiontime");
            entity.Property(e => e.Format)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("format");
            entity.Property(e => e.Interactive).HasColumnName("interactive");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Operation)
                .HasMaxLength(20)
                .HasDefaultValueSql("'backup'")
                .HasColumnName("operation");
            entity.Property(e => e.Progress)
                .HasPrecision(15, 14)
                .HasColumnName("progress");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBackupCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_backup_courses", tb => tb.HasComment("To store every course backup status"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_backcour_cou_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Lastendtime).HasColumnName("lastendtime");
            entity.Property(e => e.Laststarttime).HasColumnName("laststarttime");
            entity.Property(e => e.Laststatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("'5'")
                .HasColumnName("laststatus");
            entity.Property(e => e.Nextstarttime).HasColumnName("nextstarttime");
        });

        modelBuilder.Entity<MdlBackupLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_backup_logs", tb => tb.HasComment("To store all the logs from backup and restore operations (by"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Backupid, "mdl_backlogs_bac_ix");

            entity.HasIndex(e => new { e.Backupid, e.Id }, "mdl_backlogs_bacid_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Backupid)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("backupid");
            entity.Property(e => e.Loglevel).HasColumnName("loglevel");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlBadge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge", tb => tb.HasComment("Defines badge"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_badg_cou_ix");

            entity.HasIndex(e => e.Type, "mdl_badg_typ_ix");

            entity.HasIndex(e => e.Usercreated, "mdl_badg_use2_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_badg_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attachment)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("attachment");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Expiredate).HasColumnName("expiredate");
            entity.Property(e => e.Expireperiod).HasColumnName("expireperiod");
            entity.Property(e => e.Imageauthoremail)
                .HasMaxLength(255)
                .HasColumnName("imageauthoremail");
            entity.Property(e => e.Imageauthorname)
                .HasMaxLength(255)
                .HasColumnName("imageauthorname");
            entity.Property(e => e.Imageauthorurl)
                .HasMaxLength(255)
                .HasColumnName("imageauthorurl");
            entity.Property(e => e.Imagecaption).HasColumnName("imagecaption");
            entity.Property(e => e.Issuercontact)
                .HasMaxLength(255)
                .HasColumnName("issuercontact");
            entity.Property(e => e.Issuername)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("issuername");
            entity.Property(e => e.Issuerurl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("issuerurl");
            entity.Property(e => e.Language)
                .HasMaxLength(255)
                .HasColumnName("language");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Messagesubject).HasColumnName("messagesubject");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Nextcron).HasColumnName("nextcron");
            entity.Property(e => e.Notification)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("notification");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("type");
            entity.Property(e => e.Usercreated).HasColumnName("usercreated");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlBadgeAlignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_alignment", tb => tb.HasComment("Defines competencies alignment for badges"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Badgeid, "mdl_badgcomp_bad2_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Badgeid).HasColumnName("badgeid");
            entity.Property(e => e.Targetcode)
                .HasMaxLength(255)
                .HasColumnName("targetcode");
            entity.Property(e => e.Targetdescription).HasColumnName("targetdescription");
            entity.Property(e => e.Targetframework)
                .HasMaxLength(255)
                .HasColumnName("targetframework");
            entity.Property(e => e.Targetname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("targetname");
            entity.Property(e => e.Targeturl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("targeturl");
        });

        modelBuilder.Entity<MdlBadgeBackpack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_backpack", tb => tb.HasComment("Defines settings for connecting external backpack"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Externalbackpackid, "mdl_badgback_ext_ix");

            entity.HasIndex(e => e.Userid, "mdl_badgback_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Externalbackpackid }, "mdl_badgback_useext_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Autosync).HasColumnName("autosync");
            entity.Property(e => e.Backpackuid).HasColumnName("backpackuid");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.Externalbackpackid).HasColumnName("externalbackpackid");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBadgeBackpackOauth2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_backpack_oauth2")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Externalbackpackid, "mdl_badgbackoaut_ext_ix");

            entity.HasIndex(e => e.Issuerid, "mdl_badgbackoaut_iss_ix");

            entity.HasIndex(e => e.Userid, "mdl_badgbackoaut_use2_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_badgbackoaut_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Expires).HasColumnName("expires");
            entity.Property(e => e.Externalbackpackid).HasColumnName("externalbackpackid");
            entity.Property(e => e.Issuerid).HasColumnName("issuerid");
            entity.Property(e => e.Refreshtoken).HasColumnName("refreshtoken");
            entity.Property(e => e.Scope).HasColumnName("scope");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlBadgeCriteriaMet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_criteria_met", tb => tb.HasComment("Defines criteria that were met for an issued badge"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Critid, "mdl_badgcritmet_cri_ix");

            entity.HasIndex(e => e.Issuedid, "mdl_badgcritmet_iss_ix");

            entity.HasIndex(e => e.Userid, "mdl_badgcritmet_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Critid).HasColumnName("critid");
            entity.Property(e => e.Datemet).HasColumnName("datemet");
            entity.Property(e => e.Issuedid).HasColumnName("issuedid");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBadgeCriteriaParam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_criteria_param", tb => tb.HasComment("Defines parameters for badges criteria"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Critid, "mdl_badgcritpara_cri_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Critid).HasColumnName("critid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlBadgeCriterion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_criteria", tb => tb.HasComment("Defines criteria for issuing badges"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Badgeid, "mdl_badgcrit_bad_ix");

            entity.HasIndex(e => new { e.Badgeid, e.Criteriatype }, "mdl_badgcrit_badcri_uix").IsUnique();

            entity.HasIndex(e => e.Criteriatype, "mdl_badgcrit_cri_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Badgeid).HasColumnName("badgeid");
            entity.Property(e => e.Criteriatype).HasColumnName("criteriatype");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Method)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("method");
        });

        modelBuilder.Entity<MdlBadgeEndorsement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_endorsement", tb => tb.HasComment("Defines endorsement for badge"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Badgeid, "mdl_badgendo_bad_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Badgeid).HasColumnName("badgeid");
            entity.Property(e => e.Claimcomment).HasColumnName("claimcomment");
            entity.Property(e => e.Claimid)
                .HasMaxLength(255)
                .HasColumnName("claimid");
            entity.Property(e => e.Dateissued).HasColumnName("dateissued");
            entity.Property(e => e.Issueremail)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("issueremail");
            entity.Property(e => e.Issuername)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("issuername");
            entity.Property(e => e.Issuerurl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("issuerurl");
        });

        modelBuilder.Entity<MdlBadgeExternal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_external", tb => tb.HasComment("Setting for external badges display"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Backpackid, "mdl_badgexte_bac_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assertion).HasColumnName("assertion");
            entity.Property(e => e.Backpackid).HasColumnName("backpackid");
            entity.Property(e => e.Collectionid).HasColumnName("collectionid");
            entity.Property(e => e.Entityid)
                .HasMaxLength(255)
                .HasColumnName("entityid");
        });

        modelBuilder.Entity<MdlBadgeExternalBackpack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_external_backpack")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Backpackweburl, "mdl_badgexteback_bac2_uix").IsUnique();

            entity.HasIndex(e => e.Backpackapiurl, "mdl_badgexteback_bac_uix").IsUnique();

            entity.HasIndex(e => e.Oauth2Issuerid, "mdl_badgexteback_oau_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apiversion)
                .HasMaxLength(12)
                .HasDefaultValueSql("'1.0'")
                .HasColumnName("apiversion");
            entity.Property(e => e.Backpackapiurl)
                .HasDefaultValueSql("''")
                .HasColumnName("backpackapiurl");
            entity.Property(e => e.Backpackweburl)
                .HasDefaultValueSql("''")
                .HasColumnName("backpackweburl");
            entity.Property(e => e.Oauth2Issuerid).HasColumnName("oauth2_issuerid");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlBadgeExternalIdentifier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_external_identifier")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Sitebackpackid, "mdl_badgexteiden_sit_ix");

            entity.HasIndex(e => new { e.Sitebackpackid, e.Internalid, e.Externalid, e.Type }, "mdl_badgexteiden_sitintext_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Externalid)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("externalid");
            entity.Property(e => e.Internalid)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("internalid");
            entity.Property(e => e.Sitebackpackid).HasColumnName("sitebackpackid");
            entity.Property(e => e.Type)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
        });

        modelBuilder.Entity<MdlBadgeIssued>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_issued", tb => tb.HasComment("Defines issued badges"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Badgeid, "mdl_badgissu_bad_ix");

            entity.HasIndex(e => new { e.Badgeid, e.Userid }, "mdl_badgissu_baduse_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_badgissu_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Badgeid).HasColumnName("badgeid");
            entity.Property(e => e.Dateexpire).HasColumnName("dateexpire");
            entity.Property(e => e.Dateissued).HasColumnName("dateissued");
            entity.Property(e => e.Issuernotified).HasColumnName("issuernotified");
            entity.Property(e => e.Uniquehash).HasColumnName("uniquehash");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Visible).HasColumnName("visible");
        });

        modelBuilder.Entity<MdlBadgeManualAward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_manual_award", tb => tb.HasComment("Track manual award criteria for badges"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Badgeid, "mdl_badgmanuawar_bad_ix");

            entity.HasIndex(e => e.Issuerrole, "mdl_badgmanuawar_iss2_ix");

            entity.HasIndex(e => e.Issuerid, "mdl_badgmanuawar_iss_ix");

            entity.HasIndex(e => e.Recipientid, "mdl_badgmanuawar_rec_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Badgeid).HasColumnName("badgeid");
            entity.Property(e => e.Datemet).HasColumnName("datemet");
            entity.Property(e => e.Issuerid).HasColumnName("issuerid");
            entity.Property(e => e.Issuerrole).HasColumnName("issuerrole");
            entity.Property(e => e.Recipientid).HasColumnName("recipientid");
        });

        modelBuilder.Entity<MdlBadgeRelated>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_badge_related", tb => tb.HasComment("Defines badge related for badges"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Badgeid, "mdl_badgrela_bad_ix");

            entity.HasIndex(e => new { e.Badgeid, e.Relatedbadgeid }, "mdl_badgrela_badrel_uix").IsUnique();

            entity.HasIndex(e => e.Relatedbadgeid, "mdl_badgrela_rel_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Badgeid).HasColumnName("badgeid");
            entity.Property(e => e.Relatedbadgeid).HasColumnName("relatedbadgeid");
        });

        modelBuilder.Entity<MdlBlock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_block", tb => tb.HasComment("contains all installed blocks"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "mdl_bloc_nam_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cron).HasColumnName("cron");
            entity.Property(e => e.Lastcron).HasColumnName("lastcron");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlBlockCommunity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_block_community", tb => tb.HasComment("Community block"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Coursedescription).HasColumnName("coursedescription");
            entity.Property(e => e.Coursename)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("coursename");
            entity.Property(e => e.Courseurl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("courseurl");
            entity.Property(e => e.Imageurl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("imageurl");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBlockConfigurableReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_block_configurable_reports", tb => tb.HasComment("block_configurable_reports table retrofitted from MySQL"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Components).HasColumnName("components");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Cron).HasColumnName("cron");
            entity.Property(e => e.Export)
                .HasMaxLength(255)
                .HasColumnName("export");
            entity.Property(e => e.Global).HasColumnName("global");
            entity.Property(e => e.Jsordering).HasColumnName("jsordering");
            entity.Property(e => e.Lastexecutiontime).HasColumnName("lastexecutiontime");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Ownerid).HasColumnName("ownerid");
            entity.Property(e => e.Pagination).HasColumnName("pagination");
            entity.Property(e => e.Remote)
                .HasDefaultValueSql("'0'")
                .HasColumnName("remote");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat).HasColumnName("summaryformat");
            entity.Property(e => e.Type)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
            entity.Property(e => e.Visible).HasColumnName("visible");
        });

        modelBuilder.Entity<MdlBlockInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_block_instances", tb => tb.HasComment("This table stores block instances. The type of block this is"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Parentcontextid, "mdl_blocinst_par_ix");

            entity.HasIndex(e => new { e.Parentcontextid, e.Showinsubcontexts, e.Pagetypepattern, e.Subpagepattern }, "mdl_blocinst_parshopagsub_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_blocinst_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Blockname)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("blockname");
            entity.Property(e => e.Configdata).HasColumnName("configdata");
            entity.Property(e => e.Defaultregion)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("defaultregion");
            entity.Property(e => e.Defaultweight).HasColumnName("defaultweight");
            entity.Property(e => e.Pagetypepattern)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("pagetypepattern");
            entity.Property(e => e.Parentcontextid).HasColumnName("parentcontextid");
            entity.Property(e => e.Requiredbytheme).HasColumnName("requiredbytheme");
            entity.Property(e => e.Showinsubcontexts).HasColumnName("showinsubcontexts");
            entity.Property(e => e.Subpagepattern)
                .HasMaxLength(16)
                .HasColumnName("subpagepattern");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlBlockPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_block_positions", tb => tb.HasComment("Stores the position of a sticky block_instance on a another "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Blockinstanceid, "mdl_blocposi_blo_ix");

            entity.HasIndex(e => new { e.Blockinstanceid, e.Contextid, e.Pagetype, e.Subpage }, "mdl_blocposi_bloconpagsub_uix").IsUnique();

            entity.HasIndex(e => e.Contextid, "mdl_blocposi_con_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Blockinstanceid).HasColumnName("blockinstanceid");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Pagetype)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("pagetype");
            entity.Property(e => e.Region)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("region");
            entity.Property(e => e.Subpage)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("subpage");
            entity.Property(e => e.Visible).HasColumnName("visible");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<MdlBlockRecentActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_block_recent_activity", tb => tb.HasComment("Recent activity block"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Courseid, e.Timecreated }, "mdl_blocreceacti_coutim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Cmid).HasColumnName("cmid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Modname)
                .HasMaxLength(20)
                .HasColumnName("modname");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBlockRecentlyaccesseditem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_block_recentlyaccesseditems", tb => tb.HasComment("Most recently accessed items accessed by a user"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Cmid, "mdl_blocrece_cmi_ix");

            entity.HasIndex(e => e.Courseid, "mdl_blocrece_cou_ix");

            entity.HasIndex(e => e.Userid, "mdl_blocrece_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Courseid, e.Cmid }, "mdl_blocrece_usecoucmi_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cmid).HasColumnName("cmid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Timeaccess).HasColumnName("timeaccess");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBlockRssClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_block_rss_client", tb => tb.HasComment("Remote news feed information. Contains the news feed id, the"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Preferredtitle)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("preferredtitle");
            entity.Property(e => e.Shared).HasColumnName("shared");
            entity.Property(e => e.Skiptime).HasColumnName("skiptime");
            entity.Property(e => e.Skipuntil).HasColumnName("skipuntil");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBlogAssociation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_blog_association", tb => tb.HasComment("Associations of blog entries with courses and module instanc"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Blogid, "mdl_blogasso_blo_ix");

            entity.HasIndex(e => e.Contextid, "mdl_blogasso_con_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Blogid).HasColumnName("blogid");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
        });

        modelBuilder.Entity<MdlBlogExternal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_blog_external", tb => tb.HasComment("External blog links used for RSS copying of blog entries to "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Userid, "mdl_blogexte_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Failedlastsync).HasColumnName("failedlastsync");
            entity.Property(e => e.Filtertags)
                .HasMaxLength(255)
                .HasColumnName("filtertags");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timefetched).HasColumnName("timefetched");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Url).HasColumnName("url");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_book", tb => tb.HasComment("Defines book"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Customtitles).HasColumnName("customtitles");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Navstyle)
                .HasDefaultValueSql("'1'")
                .HasColumnName("navstyle");
            entity.Property(e => e.Numbering).HasColumnName("numbering");
            entity.Property(e => e.Revision).HasColumnName("revision");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlBookChapter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_book_chapters", tb => tb.HasComment("Defines book_chapters"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Bookid, "mdl_bookchap_boo_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bookid).HasColumnName("bookid");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Contentformat).HasColumnName("contentformat");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Importsrc)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("importsrc");
            entity.Property(e => e.Pagenum).HasColumnName("pagenum");
            entity.Property(e => e.Subchapter).HasColumnName("subchapter");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        modelBuilder.Entity<MdlCacheFilter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_cache_filters", tb => tb.HasComment("For keeping information about cached data"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Filter, e.Md5key }, "mdl_cachfilt_filmd5_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Filter)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("filter");
            entity.Property(e => e.Md5key)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("md5key");
            entity.Property(e => e.Rawtext).HasColumnName("rawtext");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<MdlCacheFlag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_cache_flags", tb => tb.HasComment("Cache of time-sensitive flags"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Flagtype, "mdl_cachflag_fla_ix");

            entity.HasIndex(e => e.Name, "mdl_cachflag_nam_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Expiry).HasColumnName("expiry");
            entity.Property(e => e.Flagtype)
                .HasDefaultValueSql("''")
                .HasColumnName("flagtype");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlCapability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_capabilities", tb => tb.HasComment("this defines all capabilities"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "mdl_capa_nam_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Captype)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("captype");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextlevel).HasColumnName("contextlevel");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Riskbitmask).HasColumnName("riskbitmask");
        });

        modelBuilder.Entity<MdlChat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_chat", tb => tb.HasComment("Each of these is a chat room"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_chat_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chattime).HasColumnName("chattime");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Keepdays).HasColumnName("keepdays");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Schedule).HasColumnName("schedule");
            entity.Property(e => e.Studentlogs).HasColumnName("studentlogs");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlChatMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_chat_messages", tb => tb.HasComment("Stores all the actual chat messages"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Chatid, "mdl_chatmess_cha_ix");

            entity.HasIndex(e => e.Groupid, "mdl_chatmess_gro_ix");

            entity.HasIndex(e => new { e.Timestamp, e.Chatid }, "mdl_chatmess_timcha_ix");

            entity.HasIndex(e => e.Userid, "mdl_chatmess_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chatid).HasColumnName("chatid");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Issystem).HasColumnName("issystem");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlChatMessagesCurrent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_chat_messages_current", tb => tb.HasComment("Stores current session"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Chatid, "mdl_chatmesscurr_cha_ix");

            entity.HasIndex(e => e.Groupid, "mdl_chatmesscurr_gro_ix");

            entity.HasIndex(e => new { e.Timestamp, e.Chatid }, "mdl_chatmesscurr_timcha_ix");

            entity.HasIndex(e => e.Userid, "mdl_chatmesscurr_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chatid).HasColumnName("chatid");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Issystem).HasColumnName("issystem");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlChatUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_chat_users", tb => tb.HasComment("Keeps track of which users are in which chat rooms"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Chatid, "mdl_chatuser_cha_ix");

            entity.HasIndex(e => e.Groupid, "mdl_chatuser_gro_ix");

            entity.HasIndex(e => e.Lastping, "mdl_chatuser_las_ix");

            entity.HasIndex(e => e.Userid, "mdl_chatuser_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chatid).HasColumnName("chatid");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Firstping).HasColumnName("firstping");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Ip)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ip");
            entity.Property(e => e.Lang)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("lang");
            entity.Property(e => e.Lastmessageping).HasColumnName("lastmessageping");
            entity.Property(e => e.Lastping).HasColumnName("lastping");
            entity.Property(e => e.Sid)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("sid");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Version)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlChoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_choice", tb => tb.HasComment("Available choices are stored here"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_choi_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allowmultiple).HasColumnName("allowmultiple");
            entity.Property(e => e.Allowupdate).HasColumnName("allowupdate");
            entity.Property(e => e.Completionsubmit).HasColumnName("completionsubmit");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Display).HasColumnName("display");
            entity.Property(e => e.Includeinactive)
                .HasDefaultValueSql("'1'")
                .HasColumnName("includeinactive");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Limitanswers).HasColumnName("limitanswers");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Publish).HasColumnName("publish");
            entity.Property(e => e.Showavailable).HasColumnName("showavailable");
            entity.Property(e => e.Showpreview).HasColumnName("showpreview");
            entity.Property(e => e.Showresults).HasColumnName("showresults");
            entity.Property(e => e.Showunanswered).HasColumnName("showunanswered");
            entity.Property(e => e.Timeclose).HasColumnName("timeclose");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timeopen).HasColumnName("timeopen");
        });

        modelBuilder.Entity<MdlChoiceAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_choice_answers", tb => tb.HasComment("choices performed by users"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Choiceid, "mdl_choiansw_cho_ix");

            entity.HasIndex(e => e.Optionid, "mdl_choiansw_opt_ix");

            entity.HasIndex(e => e.Userid, "mdl_choiansw_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Choiceid).HasColumnName("choiceid");
            entity.Property(e => e.Optionid).HasColumnName("optionid");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlChoiceOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_choice_options", tb => tb.HasComment("available options to choice"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Choiceid, "mdl_choiopti_cho_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Choiceid).HasColumnName("choiceid");
            entity.Property(e => e.Maxanswers)
                .HasDefaultValueSql("'0'")
                .HasColumnName("maxanswers");
            entity.Property(e => e.Text).HasColumnName("text");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlCohort>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_cohort", tb => tb.HasComment("Each record represents one cohort (aka site-wide group)."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_coho_con_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Name)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .HasColumnName("theme");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlCohortMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_cohort_members", tb => tb.HasComment("Link a user to a cohort."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Cohortid, "mdl_cohomemb_coh_ix");

            entity.HasIndex(e => new { e.Cohortid, e.Userid }, "mdl_cohomemb_cohuse_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_cohomemb_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cohortid).HasColumnName("cohortid");
            entity.Property(e => e.Timeadded).HasColumnName("timeadded");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_comments", tb => tb.HasComment("moodle comments module"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Contextid, e.Commentarea, e.Itemid }, "mdl_comm_concomite_ix");

            entity.HasIndex(e => e.Userid, "mdl_comm_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Commentarea)
                .HasDefaultValueSql("''")
                .HasColumnName("commentarea");
            entity.Property(e => e.Component)
                .HasMaxLength(255)
                .HasColumnName("component");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Format).HasColumnName("format");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlCompetency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency", tb => tb.HasComment("This table contains the master record of each competency in "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Competencyframeworkid, e.Idnumber }, "mdl_comp_comidn_uix").IsUnique();

            entity.HasIndex(e => e.Ruleoutcome, "mdl_comp_rul_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Competencyframeworkid).HasColumnName("competencyframeworkid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Parentid).HasColumnName("parentid");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("path");
            entity.Property(e => e.Ruleconfig).HasColumnName("ruleconfig");
            entity.Property(e => e.Ruleoutcome).HasColumnName("ruleoutcome");
            entity.Property(e => e.Ruletype)
                .HasMaxLength(100)
                .HasColumnName("ruletype");
            entity.Property(e => e.Scaleconfiguration).HasColumnName("scaleconfiguration");
            entity.Property(e => e.Scaleid).HasColumnName("scaleid");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasColumnName("shortname");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyCoursecomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_coursecomp", tb => tb.HasComment("Link a competency to a course."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Competencyid, "mdl_compcour_com_ix");

            entity.HasIndex(e => e.Courseid, "mdl_compcour_cou2_ix");

            entity.HasIndex(e => new { e.Courseid, e.Competencyid }, "mdl_compcour_coucom_uix").IsUnique();

            entity.HasIndex(e => new { e.Courseid, e.Ruleoutcome }, "mdl_compcour_courul_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Competencyid).HasColumnName("competencyid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Ruleoutcome).HasColumnName("ruleoutcome");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyCoursecompsetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_coursecompsetting", tb => tb.HasComment("This table contains the course specific settings for compete"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_compcour_cou_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Pushratingstouserplans).HasColumnName("pushratingstouserplans");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyEvidence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_evidence", tb => tb.HasComment("The evidence linked to a user competency"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Usercompetencyid, "mdl_compevid_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Actionuserid).HasColumnName("actionuserid");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Desca).HasColumnName("desca");
            entity.Property(e => e.Desccomponent)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("desccomponent");
            entity.Property(e => e.Descidentifier)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("descidentifier");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.Usercompetencyid).HasColumnName("usercompetencyid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyFramework>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_framework", tb => tb.HasComment("List of competency frameworks."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Idnumber, "mdl_compfram_idn_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Scaleconfiguration).HasColumnName("scaleconfiguration");
            entity.Property(e => e.Scaleid).HasColumnName("scaleid");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasColumnName("shortname");
            entity.Property(e => e.Taxonomies)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("taxonomies");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlCompetencyModulecomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_modulecomp", tb => tb.HasComment("Link a competency to a module."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Cmid, "mdl_compmodu_cmi_ix");

            entity.HasIndex(e => new { e.Cmid, e.Competencyid }, "mdl_compmodu_cmicom_uix").IsUnique();

            entity.HasIndex(e => new { e.Cmid, e.Ruleoutcome }, "mdl_compmodu_cmirul_ix");

            entity.HasIndex(e => e.Competencyid, "mdl_compmodu_com_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cmid).HasColumnName("cmid");
            entity.Property(e => e.Competencyid).HasColumnName("competencyid");
            entity.Property(e => e.Ruleoutcome).HasColumnName("ruleoutcome");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_plan", tb => tb.HasComment("Learning plans"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Status, e.Duedate }, "mdl_compplan_stadue_ix");

            entity.HasIndex(e => e.Templateid, "mdl_compplan_tem_ix");

            entity.HasIndex(e => new { e.Userid, e.Status }, "mdl_compplan_usesta_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Duedate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("duedate");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Origtemplateid).HasColumnName("origtemplateid");
            entity.Property(e => e.Reviewerid).HasColumnName("reviewerid");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Templateid).HasColumnName("templateid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyPlancomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_plancomp", tb => tb.HasComment("Plan competencies"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Planid, e.Competencyid }, "mdl_compplan_placom_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Competencyid).HasColumnName("competencyid");
            entity.Property(e => e.Planid).HasColumnName("planid");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyRelatedcomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_relatedcomp", tb => tb.HasComment("Related competencies"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Competencyid).HasColumnName("competencyid");
            entity.Property(e => e.Relatedcompetencyid).HasColumnName("relatedcompetencyid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_template", tb => tb.HasComment("Learning plan templates."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Duedate).HasColumnName("duedate");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasColumnName("shortname");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlCompetencyTemplatecohort>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_templatecohort", tb => tb.HasComment("Default comment for the table, please edit me"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Templateid, "mdl_comptemp_tem2_ix");

            entity.HasIndex(e => new { e.Templateid, e.Cohortid }, "mdl_comptemp_temcoh_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cohortid).HasColumnName("cohortid");
            entity.Property(e => e.Templateid).HasColumnName("templateid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyTemplatecomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_templatecomp", tb => tb.HasComment("Link a competency to a learning plan template."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Competencyid, "mdl_comptemp_com_ix");

            entity.HasIndex(e => e.Templateid, "mdl_comptemp_tem_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Competencyid).HasColumnName("competencyid");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Templateid).HasColumnName("templateid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyUsercomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_usercomp", tb => tb.HasComment("User competencies"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Userid, e.Competencyid }, "mdl_compuser_usecom_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Competencyid).HasColumnName("competencyid");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Proficiency).HasColumnName("proficiency");
            entity.Property(e => e.Reviewerid).HasColumnName("reviewerid");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyUsercompcourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_usercompcourse", tb => tb.HasComment("User competencies in a course"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Userid, e.Courseid, e.Competencyid }, "mdl_compuser_usecoucom_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Competencyid).HasColumnName("competencyid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Proficiency).HasColumnName("proficiency");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyUsercompplan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_usercompplan", tb => tb.HasComment("User competencies plans"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Userid, e.Competencyid, e.Planid }, "mdl_compuser_usecompla_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Competencyid).HasColumnName("competencyid");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Planid).HasColumnName("planid");
            entity.Property(e => e.Proficiency).HasColumnName("proficiency");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyUserevidence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_userevidence", tb => tb.HasComment("The evidence of prior learning"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Userid, "mdl_compuser_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Url).HasColumnName("url");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyUserevidencecomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_competency_userevidencecomp", tb => tb.HasComment("Relationship between user evidence and competencies"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Userevidenceid, "mdl_compuser_use2_ix");

            entity.HasIndex(e => new { e.Userevidenceid, e.Competencyid }, "mdl_compuser_usecom2_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Competencyid).HasColumnName("competencyid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userevidenceid).HasColumnName("userevidenceid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_config", tb => tb.HasComment("Moodle configuration variables"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "mdl_conf_nam_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlConfigLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_config_log", tb => tb.HasComment("Changes done in server configuration through admin UI"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Timemodified, "mdl_conflog_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_conflog_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Oldvalue).HasColumnName("oldvalue");
            entity.Property(e => e.Plugin)
                .HasMaxLength(100)
                .HasColumnName("plugin");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlConfigPlugin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_config_plugins", tb => tb.HasComment("Moodle modules and plugins configuration variables"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Plugin, e.Name }, "mdl_confplug_plunam_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Plugin)
                .HasMaxLength(100)
                .HasDefaultValueSql("'core'")
                .HasColumnName("plugin");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlContentbankContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_contentbank_content")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_contcont_con_ix");

            entity.HasIndex(e => new { e.Contextid, e.Contenttype, e.Instanceid }, "mdl_contcont_conconins_ix");

            entity.HasIndex(e => e.Name, "mdl_contcont_nam_ix");

            entity.HasIndex(e => e.Usercreated, "mdl_contcont_use2_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_contcont_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Configdata).HasColumnName("configdata");
            entity.Property(e => e.Contenttype)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("contenttype");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Instanceid).HasColumnName("instanceid");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasDefaultValueSql("'0'")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usercreated).HasColumnName("usercreated");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
            entity.Property(e => e.Visibility)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visibility");
        });

        modelBuilder.Entity<MdlContext>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_context", tb => tb.HasComment("one of these must be set"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Contextlevel, e.Instanceid }, "mdl_cont_conins_uix").IsUnique();

            entity.HasIndex(e => e.Instanceid, "mdl_cont_ins_ix");

            entity.HasIndex(e => e.Path, "mdl_cont_pat_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextlevel).HasColumnName("contextlevel");
            entity.Property(e => e.Depth).HasColumnName("depth");
            entity.Property(e => e.Instanceid).HasColumnName("instanceid");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Path).HasColumnName("path");
        });

        modelBuilder.Entity<MdlContextTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_context_temp", tb => tb.HasComment("Used by build_context_path() in upgrade and cron to keep con"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Depth).HasColumnName("depth");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("path");
        });

        modelBuilder.Entity<MdlCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course", tb => tb.HasComment("Central course table"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Category, "mdl_cour_cat_ix");

            entity.HasIndex(e => e.Idnumber, "mdl_cour_idn_ix");

            entity.HasIndex(e => e.Shortname, "mdl_cour_sho_ix");

            entity.HasIndex(e => e.Sortorder, "mdl_cour_sor_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cacherev).HasColumnName("cacherev");
            entity.Property(e => e.Calendartype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("calendartype");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Codcourse)
                .HasColumnType("text")
                .HasColumnName("codcourse");
            entity.Property(e => e.Completionnotify).HasColumnName("completionnotify");
            entity.Property(e => e.Defaultgroupingid).HasColumnName("defaultgroupingid");
            entity.Property(e => e.Downloadcontent).HasColumnName("downloadcontent");
            entity.Property(e => e.Enablecompletion).HasColumnName("enablecompletion");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.Format)
                .HasMaxLength(21)
                .HasDefaultValueSql("'topics'")
                .HasColumnName("format");
            entity.Property(e => e.Fullname)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("fullname");
            entity.Property(e => e.Groupmode).HasColumnName("groupmode");
            entity.Property(e => e.Groupmodeforce).HasColumnName("groupmodeforce");
            entity.Property(e => e.Horario)
                .HasColumnType("text")
                .HasColumnName("horario");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("idnumber");
            entity.Property(e => e.Lang)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("lang");
            entity.Property(e => e.Legacyfiles).HasColumnName("legacyfiles");
            entity.Property(e => e.Marker).HasColumnName("marker");
            entity.Property(e => e.Maxbytes).HasColumnName("maxbytes");
            entity.Property(e => e.Naturaleza)
                .HasColumnType("text")
                .HasColumnName("naturaleza");
            entity.Property(e => e.Newsitems)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("newsitems");
            entity.Property(e => e.Originalcourseid).HasColumnName("originalcourseid");
            entity.Property(e => e.Plan).HasColumnName("plan");
            entity.Property(e => e.Relativedatesmode).HasColumnName("relativedatesmode");
            entity.Property(e => e.Requested).HasColumnName("requested");
            entity.Property(e => e.Section).HasColumnName("section");
            entity.Property(e => e.Shortname)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Showactivitydates).HasColumnName("showactivitydates");
            entity.Property(e => e.Showcompletionconditions).HasColumnName("showcompletionconditions");
            entity.Property(e => e.Showgrades)
                .HasDefaultValueSql("'1'")
                .HasColumnName("showgrades");
            entity.Property(e => e.Showreports).HasColumnName("showreports");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat).HasColumnName("summaryformat");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("theme");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
            entity.Property(e => e.Visibleold)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visibleold");
        });

        modelBuilder.Entity<MdlCourseCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course_categories", tb => tb.HasComment("Course categories"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Parent, "mdl_courcate_par_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Coursecount).HasColumnName("coursecount");
            entity.Property(e => e.Depth).HasColumnName("depth");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("path");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .HasColumnName("theme");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
            entity.Property(e => e.Visibleold)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visibleold");
        });

        modelBuilder.Entity<MdlCourseCompletion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course_completions", tb => tb.HasComment("Course completion records"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_courcomp_cou_ix");

            entity.HasIndex(e => e.Timecompleted, "mdl_courcomp_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_courcomp_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Course }, "mdl_courcomp_usecou_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Reaggregate).HasColumnName("reaggregate");
            entity.Property(e => e.Timecompleted).HasColumnName("timecompleted");
            entity.Property(e => e.Timeenrolled).HasColumnName("timeenrolled");
            entity.Property(e => e.Timestarted).HasColumnName("timestarted");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlCourseCompletionAggrMethd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course_completion_aggr_methd", tb => tb.HasComment("Course completion aggregation methods for criteria"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_courcompaggrmeth_cou_ix");

            entity.HasIndex(e => new { e.Course, e.Criteriatype }, "mdl_courcompaggrmeth_coucr_uix").IsUnique();

            entity.HasIndex(e => e.Criteriatype, "mdl_courcompaggrmeth_cri_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Criteriatype).HasColumnName("criteriatype");
            entity.Property(e => e.Method).HasColumnName("method");
            entity.Property(e => e.Value)
                .HasPrecision(10, 5)
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlCourseCompletionCritCompl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course_completion_crit_compl", tb => tb.HasComment("Course completion user records"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_courcompcritcomp_cou_ix");

            entity.HasIndex(e => e.Criteriaid, "mdl_courcompcritcomp_cri_ix");

            entity.HasIndex(e => e.Timecompleted, "mdl_courcompcritcomp_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_courcompcritcomp_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Course, e.Criteriaid }, "mdl_courcompcritcomp_useco_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Criteriaid).HasColumnName("criteriaid");
            entity.Property(e => e.Gradefinal)
                .HasPrecision(10, 5)
                .HasColumnName("gradefinal");
            entity.Property(e => e.Timecompleted).HasColumnName("timecompleted");
            entity.Property(e => e.Unenroled).HasColumnName("unenroled");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlCourseCompletionCriterion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course_completion_criteria", tb => tb.HasComment("Course completion criteria"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_courcompcrit_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Courseinstance).HasColumnName("courseinstance");
            entity.Property(e => e.Criteriatype).HasColumnName("criteriatype");
            entity.Property(e => e.Enrolperiod).HasColumnName("enrolperiod");
            entity.Property(e => e.Gradepass)
                .HasPrecision(10, 5)
                .HasColumnName("gradepass");
            entity.Property(e => e.Module)
                .HasMaxLength(100)
                .HasColumnName("module");
            entity.Property(e => e.Moduleinstance).HasColumnName("moduleinstance");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Timeend).HasColumnName("timeend");
        });

        modelBuilder.Entity<MdlCourseCompletionDefault>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course_completion_defaults", tb => tb.HasComment("Default settings for activities completion"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_courcompdefa_cou_ix");

            entity.HasIndex(e => new { e.Course, e.Module }, "mdl_courcompdefa_coumod_uix").IsUnique();

            entity.HasIndex(e => e.Module, "mdl_courcompdefa_mod_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Completion).HasColumnName("completion");
            entity.Property(e => e.Completionexpected).HasColumnName("completionexpected");
            entity.Property(e => e.Completionusegrade).HasColumnName("completionusegrade");
            entity.Property(e => e.Completionview).HasColumnName("completionview");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Customrules).HasColumnName("customrules");
            entity.Property(e => e.Module).HasColumnName("module");
        });

        modelBuilder.Entity<MdlCourseFormatOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course_format_options", tb => tb.HasComment("Stores format-specific options for the course or course sect"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_courformopti_cou_ix");

            entity.HasIndex(e => new { e.Courseid, e.Format, e.Sectionid, e.Name }, "mdl_courformopti_couforsec_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Format)
                .HasMaxLength(21)
                .HasDefaultValueSql("''")
                .HasColumnName("format");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Sectionid).HasColumnName("sectionid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlCourseModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course_modules", tb => tb.HasComment("course_modules table retrofitted from MySQL"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_courmodu_cou_ix");

            entity.HasIndex(e => e.Groupingid, "mdl_courmodu_gro_ix");

            entity.HasIndex(e => new { e.Idnumber, e.Course }, "mdl_courmodu_idncou_ix");

            entity.HasIndex(e => e.Instance, "mdl_courmodu_ins_ix");

            entity.HasIndex(e => e.Module, "mdl_courmodu_mod_ix");

            entity.HasIndex(e => e.Visible, "mdl_courmodu_vis_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Added).HasColumnName("added");
            entity.Property(e => e.Availability).HasColumnName("availability");
            entity.Property(e => e.Completion).HasColumnName("completion");
            entity.Property(e => e.Completionexpected).HasColumnName("completionexpected");
            entity.Property(e => e.Completiongradeitemnumber).HasColumnName("completiongradeitemnumber");
            entity.Property(e => e.Completionview).HasColumnName("completionview");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Deletioninprogress).HasColumnName("deletioninprogress");
            entity.Property(e => e.Groupingid).HasColumnName("groupingid");
            entity.Property(e => e.Groupmode).HasColumnName("groupmode");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Indent)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("indent");
            entity.Property(e => e.Instance).HasColumnName("instance");
            entity.Property(e => e.Module).HasColumnName("module");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Section).HasColumnName("section");
            entity.Property(e => e.Showdescription).HasColumnName("showdescription");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
            entity.Property(e => e.Visibleold)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visibleold");
            entity.Property(e => e.Visibleoncoursepage)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visibleoncoursepage");
        });

        modelBuilder.Entity<MdlCourseModulesCompletion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course_modules_completion", tb => tb.HasComment("Stores the completion state (completed or not completed, etc"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Coursemoduleid, "mdl_courmoducomp_cou_ix");

            entity.HasIndex(e => new { e.Userid, e.Coursemoduleid }, "mdl_courmoducomp_usecou_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Completionstate).HasColumnName("completionstate");
            entity.Property(e => e.Coursemoduleid).HasColumnName("coursemoduleid");
            entity.Property(e => e.Overrideby).HasColumnName("overrideby");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Viewed).HasColumnName("viewed");
        });

        modelBuilder.Entity<MdlCoursePublished>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course_published", tb => tb.HasComment("Information about how and when an local courses were publish"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Enrollable)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enrollable");
            entity.Property(e => e.Hubcourseid).HasColumnName("hubcourseid");
            entity.Property(e => e.Huburl)
                .HasMaxLength(255)
                .HasColumnName("huburl");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnName("status");
            entity.Property(e => e.Timechecked).HasColumnName("timechecked");
            entity.Property(e => e.Timepublished).HasColumnName("timepublished");
        });

        modelBuilder.Entity<MdlCourseRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course_request", tb => tb.HasComment("course requests"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Shortname, "mdl_courrequ_sho_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Fullname)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("fullname");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("password");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.Requester).HasColumnName("requester");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat).HasColumnName("summaryformat");
        });

        modelBuilder.Entity<MdlCourseSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_course_sections", tb => tb.HasComment("to define the sections for each course"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Course, e.Section }, "mdl_coursect_cousec_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Availability).HasColumnName("availability");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Section).HasColumnName("section");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat).HasColumnName("summaryformat");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlCustomcert>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_customcert", tb => tb.HasComment("Defines customcerts"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Templateid, "mdl_cust_tem_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Deliveryoption)
                .HasMaxLength(255)
                .HasColumnName("deliveryoption");
            entity.Property(e => e.Emailothers).HasColumnName("emailothers");
            entity.Property(e => e.Emailstudents).HasColumnName("emailstudents");
            entity.Property(e => e.Emailteachers).HasColumnName("emailteachers");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Protection)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("protection");
            entity.Property(e => e.Requiredtime).HasColumnName("requiredtime");
            entity.Property(e => e.Templateid).HasColumnName("templateid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Verifyany).HasColumnName("verifyany");
        });

        modelBuilder.Entity<MdlCustomcertElement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_customcert_elements", tb => tb.HasComment("Stores the elements for a given page"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Pageid, "mdl_custelem_pag_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Colour)
                .HasMaxLength(50)
                .HasColumnName("colour");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Element)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("element");
            entity.Property(e => e.Font)
                .HasMaxLength(255)
                .HasColumnName("font");
            entity.Property(e => e.Fontsize).HasColumnName("fontsize");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Pageid).HasColumnName("pageid");
            entity.Property(e => e.Posx).HasColumnName("posx");
            entity.Property(e => e.Posy).HasColumnName("posy");
            entity.Property(e => e.Refpoint).HasColumnName("refpoint");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Width).HasColumnName("width");
        });

        modelBuilder.Entity<MdlCustomcertIssue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_customcert_issues", tb => tb.HasComment("Stores each issue of a customcert"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Customcertid, "mdl_custissu_cus_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(40)
                .HasColumnName("code");
            entity.Property(e => e.Customcertid).HasColumnName("customcertid");
            entity.Property(e => e.Emailed).HasColumnName("emailed");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlCustomcertPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_customcert_pages", tb => tb.HasComment("Stores each page of a custom cert"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Templateid, "mdl_custpage_tem_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Leftmargin).HasColumnName("leftmargin");
            entity.Property(e => e.Rightmargin).HasColumnName("rightmargin");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Templateid).HasColumnName("templateid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Width).HasColumnName("width");
        });

        modelBuilder.Entity<MdlCustomcertTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_customcert_templates", tb => tb.HasComment("Stores each customcert template"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_custtemp_con_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlCustomfieldCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_customfield_category")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Component, e.Area, e.Itemid, e.Sortorder }, "mdl_custcate_comareitesor_ix");

            entity.HasIndex(e => e.Contextid, "mdl_custcate_con_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("area");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlCustomfieldDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_customfield_data")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_custdata_con_ix");

            entity.HasIndex(e => e.Fieldid, "mdl_custdata_fie_ix");

            entity.HasIndex(e => new { e.Fieldid, e.Decvalue }, "mdl_custdata_fiedec_ix");

            entity.HasIndex(e => new { e.Fieldid, e.Intvalue }, "mdl_custdata_fieint_ix");

            entity.HasIndex(e => new { e.Fieldid, e.Shortcharvalue }, "mdl_custdata_fiesho_ix");

            entity.HasIndex(e => new { e.Instanceid, e.Fieldid }, "mdl_custdata_insfie_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Charvalue)
                .HasMaxLength(1333)
                .HasColumnName("charvalue");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Decvalue)
                .HasPrecision(10, 5)
                .HasColumnName("decvalue");
            entity.Property(e => e.Fieldid).HasColumnName("fieldid");
            entity.Property(e => e.Instanceid).HasColumnName("instanceid");
            entity.Property(e => e.Intvalue).HasColumnName("intvalue");
            entity.Property(e => e.Shortcharvalue).HasColumnName("shortcharvalue");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.Valueformat).HasColumnName("valueformat");
        });

        modelBuilder.Entity<MdlCustomfieldField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_customfield_field")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Categoryid, "mdl_custfiel_cat_ix");

            entity.HasIndex(e => new { e.Categoryid, e.Sortorder }, "mdl_custfiel_catsor_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Configdata).HasColumnName("configdata");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
        });

        modelBuilder.Entity<MdlDataContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_data_content", tb => tb.HasComment("the content introduced in each record/fields"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Fieldid, "mdl_datacont_fie_ix");

            entity.HasIndex(e => e.Recordid, "mdl_datacont_rec_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Content1).HasColumnName("content1");
            entity.Property(e => e.Content2).HasColumnName("content2");
            entity.Property(e => e.Content3).HasColumnName("content3");
            entity.Property(e => e.Content4).HasColumnName("content4");
            entity.Property(e => e.Fieldid).HasColumnName("fieldid");
            entity.Property(e => e.Recordid).HasColumnName("recordid");
        });

        modelBuilder.Entity<MdlDataField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_data_fields", tb => tb.HasComment("every field available"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Dataid, "mdl_datafiel_dat_ix");

            entity.HasIndex(e => new { e.Type, e.Dataid }, "mdl_datafiel_typdat_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dataid).HasColumnName("dataid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Param1).HasColumnName("param1");
            entity.Property(e => e.Param10).HasColumnName("param10");
            entity.Property(e => e.Param2).HasColumnName("param2");
            entity.Property(e => e.Param3).HasColumnName("param3");
            entity.Property(e => e.Param4).HasColumnName("param4");
            entity.Property(e => e.Param5).HasColumnName("param5");
            entity.Property(e => e.Param6).HasColumnName("param6");
            entity.Property(e => e.Param7).HasColumnName("param7");
            entity.Property(e => e.Param8).HasColumnName("param8");
            entity.Property(e => e.Param9).HasColumnName("param9");
            entity.Property(e => e.Required).HasColumnName("required");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
        });

        modelBuilder.Entity<MdlDataRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_data_records", tb => tb.HasComment("every record introduced"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Dataid, "mdl_datareco_dat_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.Dataid).HasColumnName("dataid");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_data", tb => tb.HasComment("all database activities"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_data_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Addtemplate).HasColumnName("addtemplate");
            entity.Property(e => e.Approval).HasColumnName("approval");
            entity.Property(e => e.Asearchtemplate).HasColumnName("asearchtemplate");
            entity.Property(e => e.Assessed).HasColumnName("assessed");
            entity.Property(e => e.Assesstimefinish).HasColumnName("assesstimefinish");
            entity.Property(e => e.Assesstimestart).HasColumnName("assesstimestart");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.Completionentries)
                .HasDefaultValueSql("'0'")
                .HasColumnName("completionentries");
            entity.Property(e => e.Config).HasColumnName("config");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Csstemplate).HasColumnName("csstemplate");
            entity.Property(e => e.Defaultsort).HasColumnName("defaultsort");
            entity.Property(e => e.Defaultsortdir).HasColumnName("defaultsortdir");
            entity.Property(e => e.Editany).HasColumnName("editany");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Jstemplate).HasColumnName("jstemplate");
            entity.Property(e => e.Listtemplate).HasColumnName("listtemplate");
            entity.Property(e => e.Listtemplatefooter).HasColumnName("listtemplatefooter");
            entity.Property(e => e.Listtemplateheader).HasColumnName("listtemplateheader");
            entity.Property(e => e.Manageapproved)
                .HasDefaultValueSql("'1'")
                .HasColumnName("manageapproved");
            entity.Property(e => e.Maxentries).HasColumnName("maxentries");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Notification).HasColumnName("notification");
            entity.Property(e => e.Requiredentries).HasColumnName("requiredentries");
            entity.Property(e => e.Requiredentriestoview).HasColumnName("requiredentriestoview");
            entity.Property(e => e.Rssarticles).HasColumnName("rssarticles");
            entity.Property(e => e.Rsstemplate).HasColumnName("rsstemplate");
            entity.Property(e => e.Rsstitletemplate).HasColumnName("rsstitletemplate");
            entity.Property(e => e.Scale).HasColumnName("scale");
            entity.Property(e => e.Singletemplate).HasColumnName("singletemplate");
            entity.Property(e => e.Timeavailablefrom).HasColumnName("timeavailablefrom");
            entity.Property(e => e.Timeavailableto).HasColumnName("timeavailableto");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timeviewfrom).HasColumnName("timeviewfrom");
            entity.Property(e => e.Timeviewto).HasColumnName("timeviewto");
        });

        modelBuilder.Entity<MdlEditorAttoAutosave>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_editor_atto_autosave", tb => tb.HasComment("Draft text that is auto-saved every 5 seconds while an edito"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Elementid, e.Contextid, e.Userid, e.Pagehash }, "mdl_editattoauto_eleconuse_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Draftid).HasColumnName("draftid");
            entity.Property(e => e.Drafttext).HasColumnName("drafttext");
            entity.Property(e => e.Elementid)
                .HasDefaultValueSql("''")
                .HasColumnName("elementid");
            entity.Property(e => e.Pagehash)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("pagehash");
            entity.Property(e => e.Pageinstance)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("pageinstance");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlEnrol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol", tb => tb.HasComment("Instances of enrolment plugins used in courses, fields marke"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_enro_cou_ix");

            entity.HasIndex(e => e.Enrol, "mdl_enro_enr_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cost)
                .HasMaxLength(20)
                .HasColumnName("cost");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("currency");
            entity.Property(e => e.Customchar1)
                .HasMaxLength(255)
                .HasColumnName("customchar1");
            entity.Property(e => e.Customchar2)
                .HasMaxLength(255)
                .HasColumnName("customchar2");
            entity.Property(e => e.Customchar3)
                .HasMaxLength(1333)
                .HasColumnName("customchar3");
            entity.Property(e => e.Customdec1)
                .HasPrecision(12, 7)
                .HasColumnName("customdec1");
            entity.Property(e => e.Customdec2)
                .HasPrecision(12, 7)
                .HasColumnName("customdec2");
            entity.Property(e => e.Customint1).HasColumnName("customint1");
            entity.Property(e => e.Customint2).HasColumnName("customint2");
            entity.Property(e => e.Customint3).HasColumnName("customint3");
            entity.Property(e => e.Customint4).HasColumnName("customint4");
            entity.Property(e => e.Customint5).HasColumnName("customint5");
            entity.Property(e => e.Customint6).HasColumnName("customint6");
            entity.Property(e => e.Customint7).HasColumnName("customint7");
            entity.Property(e => e.Customint8).HasColumnName("customint8");
            entity.Property(e => e.Customtext1).HasColumnName("customtext1");
            entity.Property(e => e.Customtext2).HasColumnName("customtext2");
            entity.Property(e => e.Customtext3).HasColumnName("customtext3");
            entity.Property(e => e.Customtext4).HasColumnName("customtext4");
            entity.Property(e => e.Enrol)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("enrol");
            entity.Property(e => e.Enrolenddate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("enrolenddate");
            entity.Property(e => e.Enrolperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnName("enrolperiod");
            entity.Property(e => e.Enrolstartdate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("enrolstartdate");
            entity.Property(e => e.Expirynotify)
                .HasDefaultValueSql("'0'")
                .HasColumnName("expirynotify");
            entity.Property(e => e.Expirythreshold)
                .HasDefaultValueSql("'0'")
                .HasColumnName("expirythreshold");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Notifyall)
                .HasDefaultValueSql("'0'")
                .HasColumnName("notifyall");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Roleid)
                .HasDefaultValueSql("'0'")
                .HasColumnName("roleid");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlEnrolFlatfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol_flatfile", tb => tb.HasComment("enrol_flatfile table retrofitted from MySQL"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_enroflat_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_enroflat_rol_ix");

            entity.HasIndex(e => e.Userid, "mdl_enroflat_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Timeend).HasColumnName("timeend");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timestart).HasColumnName("timestart");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2Consumer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol_lti_lti2_consumer", tb => tb.HasComment("LTI consumers interacting with moodle"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Consumerkey256, "mdl_enroltilti2cons_con_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Consumerguid)
                .HasMaxLength(1024)
                .HasColumnName("consumerguid");
            entity.Property(e => e.Consumerkey).HasColumnName("consumerkey");
            entity.Property(e => e.Consumerkey256)
                .HasDefaultValueSql("''")
                .HasColumnName("consumerkey256");
            entity.Property(e => e.Consumername)
                .HasMaxLength(255)
                .HasColumnName("consumername");
            entity.Property(e => e.Consumerversion)
                .HasMaxLength(255)
                .HasColumnName("consumerversion");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Enablefrom).HasColumnName("enablefrom");
            entity.Property(e => e.Enableuntil).HasColumnName("enableuntil");
            entity.Property(e => e.Lastaccess).HasColumnName("lastaccess");
            entity.Property(e => e.Ltiversion)
                .HasMaxLength(10)
                .HasColumnName("ltiversion");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Profile).HasColumnName("profile");
            entity.Property(e => e.Protected).HasColumnName("protected");
            entity.Property(e => e.Secret)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''")
                .HasColumnName("secret");
            entity.Property(e => e.Settings).HasColumnName("settings");
            entity.Property(e => e.Toolproxy).HasColumnName("toolproxy");
            entity.Property(e => e.Updated).HasColumnName("updated");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2Context>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol_lti_lti2_context", tb => tb.HasComment("Information about a specific LTI contexts from the consumers"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Consumerid, "mdl_enroltilti2cont_con_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Consumerid).HasColumnName("consumerid");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.Lticontextkey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("lticontextkey");
            entity.Property(e => e.Settings).HasColumnName("settings");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");
            entity.Property(e => e.Updated).HasColumnName("updated");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2Nonce>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol_lti_lti2_nonce", tb => tb.HasComment("Nonce used for authentication between moodle and a consumer"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Consumerid, "mdl_enroltilti2nonc_con_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Consumerid).HasColumnName("consumerid");
            entity.Property(e => e.Expires).HasColumnName("expires");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2ResourceLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol_lti_lti2_resource_link", tb => tb.HasComment("Link from the consumer to the tool"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Consumerid, "mdl_enroltilti2resolink_co2_ix");

            entity.HasIndex(e => e.Contextid, "mdl_enroltilti2resolink_con_ix");

            entity.HasIndex(e => e.Primaryresourcelinkid, "mdl_enroltilti2resolink_pri_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Consumerid).HasColumnName("consumerid");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.Ltiresourcelinkkey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("ltiresourcelinkkey");
            entity.Property(e => e.Primaryresourcelinkid).HasColumnName("primaryresourcelinkid");
            entity.Property(e => e.Settings).HasColumnName("settings");
            entity.Property(e => e.Shareapproved).HasColumnName("shareapproved");
            entity.Property(e => e.Updated).HasColumnName("updated");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2ShareKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol_lti_lti2_share_key", tb => tb.HasComment("Resource link share key"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Resourcelinkid, "mdl_enroltilti2sharkey_res_uix").IsUnique();

            entity.HasIndex(e => e.Sharekey, "mdl_enroltilti2sharkey_sha_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Autoapprove).HasColumnName("autoapprove");
            entity.Property(e => e.Expires).HasColumnName("expires");
            entity.Property(e => e.Resourcelinkid).HasColumnName("resourcelinkid");
            entity.Property(e => e.Sharekey)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("sharekey");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2ToolProxy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol_lti_lti2_tool_proxy", tb => tb.HasComment("A tool proxy between moodle and a consumer"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Consumerid, "mdl_enroltilti2toolprox_con_ix");

            entity.HasIndex(e => e.Toolproxykey, "mdl_enroltilti2toolprox_to_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Consumerid).HasColumnName("consumerid");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.Toolproxy).HasColumnName("toolproxy");
            entity.Property(e => e.Toolproxykey)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("toolproxykey");
            entity.Property(e => e.Updated).HasColumnName("updated");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2UserResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol_lti_lti2_user_result", tb => tb.HasComment("Results for each user for each resource link"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Resourcelinkid, "mdl_enroltilti2userresu_res_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.Ltiresultsourcedid)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''")
                .HasColumnName("ltiresultsourcedid");
            entity.Property(e => e.Ltiuserkey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("ltiuserkey");
            entity.Property(e => e.Resourcelinkid).HasColumnName("resourcelinkid");
            entity.Property(e => e.Updated).HasColumnName("updated");
        });

        modelBuilder.Entity<MdlEnrolLtiTool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol_lti_tools", tb => tb.HasComment("List of tools provided to the remote system"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_enroltitool_con_ix");

            entity.HasIndex(e => e.Enrolid, "mdl_enroltitool_enr_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City)
                .HasMaxLength(120)
                .HasDefaultValueSql("''")
                .HasColumnName("city");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .HasColumnName("country");
            entity.Property(e => e.Enrolid).HasColumnName("enrolid");
            entity.Property(e => e.Gradesync).HasColumnName("gradesync");
            entity.Property(e => e.Gradesynccompletion).HasColumnName("gradesynccompletion");
            entity.Property(e => e.Institution)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("institution");
            entity.Property(e => e.Lang)
                .HasMaxLength(30)
                .HasDefaultValueSql("'en'")
                .HasColumnName("lang");
            entity.Property(e => e.Maildisplay)
                .HasDefaultValueSql("'2'")
                .HasColumnName("maildisplay");
            entity.Property(e => e.Maxenrolled).HasColumnName("maxenrolled");
            entity.Property(e => e.Membersync).HasColumnName("membersync");
            entity.Property(e => e.Membersyncmode).HasColumnName("membersyncmode");
            entity.Property(e => e.Roleinstructor).HasColumnName("roleinstructor");
            entity.Property(e => e.Rolelearner).HasColumnName("rolelearner");
            entity.Property(e => e.Secret).HasColumnName("secret");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timezone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'99'")
                .HasColumnName("timezone");
        });

        modelBuilder.Entity<MdlEnrolLtiToolConsumerMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol_lti_tool_consumer_map", tb => tb.HasComment("Table that maps the published tool to tool consumers."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Consumerid, "mdl_enroltitoolconsmap_con_ix");

            entity.HasIndex(e => e.Toolid, "mdl_enroltitoolconsmap_too_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Consumerid).HasColumnName("consumerid");
            entity.Property(e => e.Toolid).HasColumnName("toolid");
        });

        modelBuilder.Entity<MdlEnrolLtiUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol_lti_users", tb => tb.HasComment("User access log and gradeback data"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Toolid, "mdl_enroltiuser_too_ix");

            entity.HasIndex(e => e.Userid, "mdl_enroltiuser_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Consumerkey).HasColumnName("consumerkey");
            entity.Property(e => e.Consumersecret).HasColumnName("consumersecret");
            entity.Property(e => e.Lastaccess).HasColumnName("lastaccess");
            entity.Property(e => e.Lastgrade)
                .HasPrecision(10, 5)
                .HasColumnName("lastgrade");
            entity.Property(e => e.Membershipsid).HasColumnName("membershipsid");
            entity.Property(e => e.Membershipsurl).HasColumnName("membershipsurl");
            entity.Property(e => e.Serviceurl).HasColumnName("serviceurl");
            entity.Property(e => e.Sourceid).HasColumnName("sourceid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Toolid).HasColumnName("toolid");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlEnrolPaypal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_enrol_paypal", tb => tb.HasComment("Holds all known information about PayPal transactions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Business, "mdl_enropayp_bus_ix");

            entity.HasIndex(e => e.Courseid, "mdl_enropayp_cou_ix");

            entity.HasIndex(e => e.Instanceid, "mdl_enropayp_ins_ix");

            entity.HasIndex(e => e.ReceiverEmail, "mdl_enropayp_rec_ix");

            entity.HasIndex(e => e.Userid, "mdl_enropayp_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Business)
                .HasDefaultValueSql("''")
                .HasColumnName("business");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Instanceid).HasColumnName("instanceid");
            entity.Property(e => e.ItemName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("item_name");
            entity.Property(e => e.Memo)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("memo");
            entity.Property(e => e.OptionName1)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("option_name1");
            entity.Property(e => e.OptionName2)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("option_name2");
            entity.Property(e => e.OptionSelection1X)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("option_selection1_x");
            entity.Property(e => e.OptionSelection2X)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("option_selection2_x");
            entity.Property(e => e.ParentTxnId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("parent_txn_id");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("payment_status");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("payment_type");
            entity.Property(e => e.PendingReason)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("pending_reason");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("reason_code");
            entity.Property(e => e.ReceiverEmail)
                .HasDefaultValueSql("''")
                .HasColumnName("receiver_email");
            entity.Property(e => e.ReceiverId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("receiver_id");
            entity.Property(e => e.Tax)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("tax");
            entity.Property(e => e.Timeupdated).HasColumnName("timeupdated");
            entity.Property(e => e.TxnId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("txn_id");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_event", tb => tb.HasComment("For everything with a time associated to it"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Categoryid, "mdl_even_cat_ix");

            entity.HasIndex(e => new { e.Component, e.Eventtype, e.Instance }, "mdl_even_comeveins_ix");

            entity.HasIndex(e => e.Courseid, "mdl_even_cou_ix");

            entity.HasIndex(e => e.Eventtype, "mdl_even_eve_ix");

            entity.HasIndex(e => new { e.Groupid, e.Courseid, e.Categoryid, e.Visible, e.Userid }, "mdl_even_grocoucatvisuse_ix");

            entity.HasIndex(e => new { e.Modulename, e.Instance, e.Eventtype }, "mdl_even_modinseve_ix");

            entity.HasIndex(e => e.Subscriptionid, "mdl_even_sub_ix");

            entity.HasIndex(e => e.Timeduration, "mdl_even_tim2_ix");

            entity.HasIndex(e => e.Timestart, "mdl_even_tim_ix");

            entity.HasIndex(e => new { e.Type, e.Timesort }, "mdl_even_typtim_ix");

            entity.HasIndex(e => e.Userid, "mdl_even_use_ix");

            entity.HasIndex(e => e.Uuid, "mdl_even_uui_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Eventtype)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("eventtype");
            entity.Property(e => e.Format).HasColumnName("format");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Instance).HasColumnName("instance");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.Modulename)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("modulename");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.Repeatid).HasColumnName("repeatid");
            entity.Property(e => e.Sequence)
                .HasDefaultValueSql("'1'")
                .HasColumnName("sequence");
            entity.Property(e => e.Subscriptionid).HasColumnName("subscriptionid");
            entity.Property(e => e.Timeduration).HasColumnName("timeduration");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timesort).HasColumnName("timesort");
            entity.Property(e => e.Timestart).HasColumnName("timestart");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Uuid)
                .HasDefaultValueSql("''")
                .HasColumnName("uuid");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlEventSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_event_subscriptions", tb => tb.HasComment("Tracks subscriptions to remote calendars."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Eventtype)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("eventtype");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Lastupdated).HasColumnName("lastupdated");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Pollinterval).HasColumnName("pollinterval");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlEventsHandler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_events_handlers", tb => tb.HasComment("This table is for storing which components requests what typ"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Eventname, e.Component }, "mdl_evenhand_evecom_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(166)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Eventname)
                .HasMaxLength(166)
                .HasDefaultValueSql("''")
                .HasColumnName("eventname");
            entity.Property(e => e.Handlerfile)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("handlerfile");
            entity.Property(e => e.Handlerfunction).HasColumnName("handlerfunction");
            entity.Property(e => e.Internal)
                .HasDefaultValueSql("'1'")
                .HasColumnName("internal");
            entity.Property(e => e.Schedule)
                .HasMaxLength(255)
                .HasColumnName("schedule");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MdlEventsQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_events_queue", tb => tb.HasComment("This table is for storing queued events. It stores only one "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Userid, "mdl_evenqueu_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Eventdata).HasColumnName("eventdata");
            entity.Property(e => e.Stackdump).HasColumnName("stackdump");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlEventsQueueHandler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_events_queue_handlers", tb => tb.HasComment("This is the list of queued handlers for processing. The even"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Handlerid, "mdl_evenqueuhand_han_ix");

            entity.HasIndex(e => e.Queuedeventid, "mdl_evenqueuhand_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Errormessage).HasColumnName("errormessage");
            entity.Property(e => e.Handlerid).HasColumnName("handlerid");
            entity.Property(e => e.Queuedeventid).HasColumnName("queuedeventid");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlExternalFunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_external_functions", tb => tb.HasComment("list of all external functions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "mdl_extefunc_nam_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capabilities)
                .HasMaxLength(255)
                .HasColumnName("capabilities");
            entity.Property(e => e.Classname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("classname");
            entity.Property(e => e.Classpath)
                .HasMaxLength(255)
                .HasColumnName("classpath");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Methodname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("methodname");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Services)
                .HasMaxLength(1333)
                .HasColumnName("services");
        });

        modelBuilder.Entity<MdlExternalService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_external_services", tb => tb.HasComment("built in and custom external services"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "mdl_exteserv_nam_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Downloadfiles).HasColumnName("downloadfiles");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Requiredcapability)
                .HasMaxLength(150)
                .HasColumnName("requiredcapability");
            entity.Property(e => e.Restrictedusers).HasColumnName("restrictedusers");
            entity.Property(e => e.Shortname)
                .HasMaxLength(255)
                .HasColumnName("shortname");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Uploadfiles).HasColumnName("uploadfiles");
        });

        modelBuilder.Entity<MdlExternalServicesFunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_external_services_functions", tb => tb.HasComment("lists functions available in each service group"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Externalserviceid, "mdl_exteservfunc_ext_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Externalserviceid).HasColumnName("externalserviceid");
            entity.Property(e => e.Functionname)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("functionname");
        });

        modelBuilder.Entity<MdlExternalServicesUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_external_services_users", tb => tb.HasComment("users allowed to use services with restricted users flag"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Externalserviceid, "mdl_exteservuser_ext_ix");

            entity.HasIndex(e => e.Userid, "mdl_exteservuser_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Externalserviceid).HasColumnName("externalserviceid");
            entity.Property(e => e.Iprestriction)
                .HasMaxLength(255)
                .HasColumnName("iprestriction");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Validuntil).HasColumnName("validuntil");
        });

        modelBuilder.Entity<MdlExternalToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_external_tokens", tb => tb.HasComment("Security tokens for accessing of external services"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_extetoke_con_ix");

            entity.HasIndex(e => e.Creatorid, "mdl_extetoke_cre_ix");

            entity.HasIndex(e => e.Externalserviceid, "mdl_extetoke_ext_ix");

            entity.HasIndex(e => e.Token, "mdl_extetoke_tok_ix");

            entity.HasIndex(e => e.Userid, "mdl_extetoke_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Creatorid)
                .HasDefaultValueSql("'1'")
                .HasColumnName("creatorid");
            entity.Property(e => e.Externalserviceid).HasColumnName("externalserviceid");
            entity.Property(e => e.Iprestriction)
                .HasMaxLength(255)
                .HasColumnName("iprestriction");
            entity.Property(e => e.Lastaccess).HasColumnName("lastaccess");
            entity.Property(e => e.Privatetoken)
                .HasMaxLength(64)
                .HasColumnName("privatetoken");
            entity.Property(e => e.Sid)
                .HasMaxLength(128)
                .HasColumnName("sid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Token)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("token");
            entity.Property(e => e.Tokentype).HasColumnName("tokentype");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Validuntil).HasColumnName("validuntil");
        });

        modelBuilder.Entity<MdlFavourite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_favourite", tb => tb.HasComment("Stores the relationship between an arbitrary item (itemtype,"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Component, e.Itemtype, e.Itemid, e.Contextid, e.Userid }, "mdl_favo_comiteiteconuse_uix").IsUnique();

            entity.HasIndex(e => e.Contextid, "mdl_favo_con_ix");

            entity.HasIndex(e => e.Userid, "mdl_favo_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("itemtype");
            entity.Property(e => e.Ordering).HasColumnName("ordering");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlFeedback>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_feedback", tb => tb.HasComment("all feedbacks"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_feed_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Anonymous)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("anonymous");
            entity.Property(e => e.Autonumbering)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("autonumbering");
            entity.Property(e => e.Completionsubmit).HasColumnName("completionsubmit");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.EmailNotification)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("email_notification");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.MultipleSubmit)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("multiple_submit");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.PageAfterSubmit).HasColumnName("page_after_submit");
            entity.Property(e => e.PageAfterSubmitformat).HasColumnName("page_after_submitformat");
            entity.Property(e => e.PublishStats).HasColumnName("publish_stats");
            entity.Property(e => e.SiteAfterSubmit)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("site_after_submit");
            entity.Property(e => e.Timeclose).HasColumnName("timeclose");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timeopen).HasColumnName("timeopen");
        });

        modelBuilder.Entity<MdlFeedbackCompleted>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_feedback_completed", tb => tb.HasComment("filled out feedback"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Feedback, "mdl_feedcomp_fee_ix");

            entity.HasIndex(e => e.Userid, "mdl_feedcomp_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnonymousResponse).HasColumnName("anonymous_response");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.RandomResponse).HasColumnName("random_response");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlFeedbackCompletedtmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_feedback_completedtmp", tb => tb.HasComment("filled out feedback"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Feedback, "mdl_feedcomp_fee2_ix");

            entity.HasIndex(e => e.Userid, "mdl_feedcomp_use2_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnonymousResponse).HasColumnName("anonymous_response");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.Guestid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("guestid");
            entity.Property(e => e.RandomResponse).HasColumnName("random_response");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlFeedbackItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_feedback_item", tb => tb.HasComment("feedback_items"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Feedback, "mdl_feeditem_fee_ix");

            entity.HasIndex(e => e.Template, "mdl_feeditem_tem_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dependitem).HasColumnName("dependitem");
            entity.Property(e => e.Dependvalue)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("dependvalue");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.Hasvalue).HasColumnName("hasvalue");
            entity.Property(e => e.Label)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("label");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Options)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("options");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Presentation).HasColumnName("presentation");
            entity.Property(e => e.Required).HasColumnName("required");
            entity.Property(e => e.Template).HasColumnName("template");
            entity.Property(e => e.Typ)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("typ");
        });

        modelBuilder.Entity<MdlFeedbackSitecourseMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_feedback_sitecourse_map", tb => tb.HasComment("feedback sitecourse map"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_feedsitemap_cou_ix");

            entity.HasIndex(e => e.Feedbackid, "mdl_feedsitemap_fee_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Feedbackid).HasColumnName("feedbackid");
        });

        modelBuilder.Entity<MdlFeedbackTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_feedback_template", tb => tb.HasComment("templates of feedbackstructures"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_feedtemp_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Ispublic).HasColumnName("ispublic");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<MdlFeedbackValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_feedback_value", tb => tb.HasComment("values of the completeds"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Completed, e.Item, e.CourseId }, "mdl_feedvalu_comitecou_uix").IsUnique();

            entity.HasIndex(e => e.CourseId, "mdl_feedvalu_cou_ix");

            entity.HasIndex(e => e.Item, "mdl_feedvalu_ite_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Completed).HasColumnName("completed");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.TmpCompleted).HasColumnName("tmp_completed");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlFeedbackValuetmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_feedback_valuetmp", tb => tb.HasComment("values of the completedstmp"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Completed, e.Item, e.CourseId }, "mdl_feedvalu_comitecou2_uix").IsUnique();

            entity.HasIndex(e => e.CourseId, "mdl_feedvalu_cou2_ix");

            entity.HasIndex(e => e.Item, "mdl_feedvalu_ite2_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Completed).HasColumnName("completed");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.TmpCompleted).HasColumnName("tmp_completed");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_files", tb => tb.HasComment("description of files, content is stored in sha1 file pool"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Component, e.Filearea, e.Contextid, e.Itemid }, "mdl_file_comfilconite_ix");

            entity.HasIndex(e => e.Contextid, "mdl_file_con2_ix");

            entity.HasIndex(e => e.Contenthash, "mdl_file_con_ix");

            entity.HasIndex(e => e.License, "mdl_file_lic_ix");

            entity.HasIndex(e => e.Pathnamehash, "mdl_file_pat_uix").IsUnique();

            entity.HasIndex(e => e.Referencefileid, "mdl_file_ref_ix");

            entity.HasIndex(e => e.Userid, "mdl_file_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author)
                .HasMaxLength(255)
                .HasColumnName("author");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contenthash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("contenthash");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Filearea)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("filearea");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("filename");
            entity.Property(e => e.Filepath)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("filepath");
            entity.Property(e => e.Filesize).HasColumnName("filesize");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.License).HasColumnName("license");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(100)
                .HasColumnName("mimetype");
            entity.Property(e => e.Pathnamehash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("pathnamehash");
            entity.Property(e => e.Referencefileid).HasColumnName("referencefileid");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlFileConversion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_file_conversion", tb => tb.HasComment("Table to track file conversions."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Destfileid, "mdl_fileconv_des_ix");

            entity.HasIndex(e => e.Sourcefileid, "mdl_fileconv_sou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Converter)
                .HasMaxLength(255)
                .HasColumnName("converter");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Destfileid).HasColumnName("destfileid");
            entity.Property(e => e.Sourcefileid).HasColumnName("sourcefileid");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnName("status");
            entity.Property(e => e.Statusmessage).HasColumnName("statusmessage");
            entity.Property(e => e.Targetformat)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("targetformat");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlFilesReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_files_reference", tb => tb.HasComment("Store files references"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Referencehash, e.Repositoryid }, "mdl_filerefe_refrep_uix").IsUnique();

            entity.HasIndex(e => e.Repositoryid, "mdl_filerefe_rep_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lastsync).HasColumnName("lastsync");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Referencehash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("referencehash");
            entity.Property(e => e.Repositoryid).HasColumnName("repositoryid");
        });

        modelBuilder.Entity<MdlFilterActive>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_filter_active", tb => tb.HasComment("Stores information about which filters are active in which c"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_filtacti_con_ix");

            entity.HasIndex(e => new { e.Contextid, e.Filter }, "mdl_filtacti_confil_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Filter)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("filter");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlFilterConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_filter_config", tb => tb.HasComment("Stores per-context configuration settings for filters which "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_filtconf_con_ix");

            entity.HasIndex(e => new { e.Contextid, e.Filter, e.Name }, "mdl_filtconf_confilnam_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Filter)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("filter");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlFilterWirisFormula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_filter_wiris_formulas", tb => tb.HasComment("Default comment for filter_wiris, please edit me"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Md5, "mdl_filtwiriform_md5_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alt).HasColumnName("alt");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Jsoncontent).HasColumnName("jsoncontent");
            entity.Property(e => e.Md5)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("md5");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlFolder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_folder", tb => tb.HasComment("each record is one folder resource"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_fold_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Display).HasColumnName("display");
            entity.Property(e => e.Forcedownload)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("forcedownload");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Revision).HasColumnName("revision");
            entity.Property(e => e.Showdownloadfolder)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("showdownloadfolder");
            entity.Property(e => e.Showexpanded)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("showexpanded");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlForum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_forum", tb => tb.HasComment("Forums contain and structure discussion"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_foru_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assessed).HasColumnName("assessed");
            entity.Property(e => e.Assesstimefinish).HasColumnName("assesstimefinish");
            entity.Property(e => e.Assesstimestart).HasColumnName("assesstimestart");
            entity.Property(e => e.Blockafter).HasColumnName("blockafter");
            entity.Property(e => e.Blockperiod).HasColumnName("blockperiod");
            entity.Property(e => e.Completiondiscussions).HasColumnName("completiondiscussions");
            entity.Property(e => e.Completionposts).HasColumnName("completionposts");
            entity.Property(e => e.Completionreplies).HasColumnName("completionreplies");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Cutoffdate).HasColumnName("cutoffdate");
            entity.Property(e => e.Displaywordcount).HasColumnName("displaywordcount");
            entity.Property(e => e.Duedate).HasColumnName("duedate");
            entity.Property(e => e.Forcesubscribe).HasColumnName("forcesubscribe");
            entity.Property(e => e.GradeForum).HasColumnName("grade_forum");
            entity.Property(e => e.GradeForumNotify).HasColumnName("grade_forum_notify");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Lockdiscussionafter).HasColumnName("lockdiscussionafter");
            entity.Property(e => e.Maxattachments)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxattachments");
            entity.Property(e => e.Maxbytes).HasColumnName("maxbytes");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Rssarticles).HasColumnName("rssarticles");
            entity.Property(e => e.Rsstype).HasColumnName("rsstype");
            entity.Property(e => e.Scale).HasColumnName("scale");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Trackingtype)
                .HasDefaultValueSql("'1'")
                .HasColumnName("trackingtype");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasDefaultValueSql("'general'")
                .HasColumnName("type");
            entity.Property(e => e.Warnafter).HasColumnName("warnafter");
        });

        modelBuilder.Entity<MdlForumDigest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_forum_digests", tb => tb.HasComment("Keeps track of user mail delivery preferences for each forum"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Forum, "mdl_forudige_for_ix");

            entity.HasIndex(e => new { e.Forum, e.Userid, e.Maildigest }, "mdl_forudige_forusemai_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_forudige_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Forum).HasColumnName("forum");
            entity.Property(e => e.Maildigest)
                .IsRequired()
                .HasDefaultValueSql("'-1'")
                .HasColumnName("maildigest");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlForumDiscussion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_forum_discussions", tb => tb.HasComment("Forums are composed of discussions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_forudisc_cou_ix");

            entity.HasIndex(e => e.Forum, "mdl_forudisc_for_ix");

            entity.HasIndex(e => e.Userid, "mdl_forudisc_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assessed)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("assessed");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Firstpost).HasColumnName("firstpost");
            entity.Property(e => e.Forum).HasColumnName("forum");
            entity.Property(e => e.Groupid)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("groupid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Pinned).HasColumnName("pinned");
            entity.Property(e => e.Timeend).HasColumnName("timeend");
            entity.Property(e => e.Timelocked).HasColumnName("timelocked");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timestart).HasColumnName("timestart");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlForumDiscussionSub>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_forum_discussion_subs", tb => tb.HasComment("Users may choose to subscribe and unsubscribe from specific "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Discussion, "mdl_forudiscsubs_dis_ix");

            entity.HasIndex(e => e.Forum, "mdl_forudiscsubs_for_ix");

            entity.HasIndex(e => e.Userid, "mdl_forudiscsubs_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Discussion }, "mdl_forudiscsubs_usedis_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Discussion).HasColumnName("discussion");
            entity.Property(e => e.Forum).HasColumnName("forum");
            entity.Property(e => e.Preference)
                .HasDefaultValueSql("'1'")
                .HasColumnName("preference");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlForumGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_forum_grades")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Forum, "mdl_forugrad_for_ix");

            entity.HasIndex(e => new { e.Forum, e.Itemnumber, e.Userid }, "mdl_forugrad_foriteuse_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_forugrad_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Forum).HasColumnName("forum");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Itemnumber).HasColumnName("itemnumber");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlForumPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_forum_posts", tb => tb.HasComment("All posts are stored in this table"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Created, "mdl_forupost_cre_ix");

            entity.HasIndex(e => e.Discussion, "mdl_forupost_dis_ix");

            entity.HasIndex(e => e.Mailed, "mdl_forupost_mai_ix");

            entity.HasIndex(e => e.Parent, "mdl_forupost_par_ix");

            entity.HasIndex(e => e.Privatereplyto, "mdl_forupost_pri_ix");

            entity.HasIndex(e => e.Userid, "mdl_forupost_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("attachment");
            entity.Property(e => e.Charcount).HasColumnName("charcount");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Discussion).HasColumnName("discussion");
            entity.Property(e => e.Mailed).HasColumnName("mailed");
            entity.Property(e => e.Mailnow).HasColumnName("mailnow");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Messageformat).HasColumnName("messageformat");
            entity.Property(e => e.Messagetrust).HasColumnName("messagetrust");
            entity.Property(e => e.Modified).HasColumnName("modified");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Privatereplyto).HasColumnName("privatereplyto");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("subject");
            entity.Property(e => e.Totalscore).HasColumnName("totalscore");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Wordcount).HasColumnName("wordcount");
        });

        modelBuilder.Entity<MdlForumQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_forum_queue", tb => tb.HasComment("For keeping track of posts that will be mailed in digest for"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Discussionid, "mdl_foruqueu_dis_ix");

            entity.HasIndex(e => e.Postid, "mdl_foruqueu_pos_ix");

            entity.HasIndex(e => e.Userid, "mdl_foruqueu_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Discussionid).HasColumnName("discussionid");
            entity.Property(e => e.Postid).HasColumnName("postid");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlForumRead>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_forum_read", tb => tb.HasComment("Tracks each users read posts"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Postid, e.Userid }, "mdl_foruread_posuse_ix");

            entity.HasIndex(e => new { e.Userid, e.Discussionid }, "mdl_foruread_usedis_ix");

            entity.HasIndex(e => new { e.Userid, e.Forumid }, "mdl_foruread_usefor_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Discussionid).HasColumnName("discussionid");
            entity.Property(e => e.Firstread).HasColumnName("firstread");
            entity.Property(e => e.Forumid).HasColumnName("forumid");
            entity.Property(e => e.Lastread).HasColumnName("lastread");
            entity.Property(e => e.Postid).HasColumnName("postid");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlForumSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_forum_subscriptions", tb => tb.HasComment("Keeps track of who is subscribed to what forum"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Forum, "mdl_forusubs_for_ix");

            entity.HasIndex(e => e.Userid, "mdl_forusubs_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Forum }, "mdl_forusubs_usefor_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Forum).HasColumnName("forum");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlForumTrackPref>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_forum_track_prefs", tb => tb.HasComment("Tracks each users untracked forums"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Userid, e.Forumid }, "mdl_forutracpref_usefor_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Forumid).HasColumnName("forumid");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlGlossary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_glossary", tb => tb.HasComment("all glossaries"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_glos_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allowcomments).HasColumnName("allowcomments");
            entity.Property(e => e.Allowduplicatedentries).HasColumnName("allowduplicatedentries");
            entity.Property(e => e.Allowprintview)
                .HasDefaultValueSql("'1'")
                .HasColumnName("allowprintview");
            entity.Property(e => e.Approvaldisplayformat)
                .HasMaxLength(50)
                .HasDefaultValueSql("'default'")
                .HasColumnName("approvaldisplayformat");
            entity.Property(e => e.Assessed).HasColumnName("assessed");
            entity.Property(e => e.Assesstimefinish).HasColumnName("assesstimefinish");
            entity.Property(e => e.Assesstimestart).HasColumnName("assesstimestart");
            entity.Property(e => e.Completionentries).HasColumnName("completionentries");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Defaultapproval)
                .HasDefaultValueSql("'1'")
                .HasColumnName("defaultapproval");
            entity.Property(e => e.Displayformat)
                .HasMaxLength(50)
                .HasDefaultValueSql("'dictionary'")
                .HasColumnName("displayformat");
            entity.Property(e => e.Editalways).HasColumnName("editalways");
            entity.Property(e => e.Entbypage)
                .HasDefaultValueSql("'10'")
                .HasColumnName("entbypage");
            entity.Property(e => e.Globalglossary).HasColumnName("globalglossary");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Mainglossary).HasColumnName("mainglossary");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Rssarticles).HasColumnName("rssarticles");
            entity.Property(e => e.Rsstype).HasColumnName("rsstype");
            entity.Property(e => e.Scale).HasColumnName("scale");
            entity.Property(e => e.Showall)
                .HasDefaultValueSql("'1'")
                .HasColumnName("showall");
            entity.Property(e => e.Showalphabet)
                .HasDefaultValueSql("'1'")
                .HasColumnName("showalphabet");
            entity.Property(e => e.Showspecial)
                .HasDefaultValueSql("'1'")
                .HasColumnName("showspecial");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usedynalink)
                .HasDefaultValueSql("'1'")
                .HasColumnName("usedynalink");
        });

        modelBuilder.Entity<MdlGlossaryAlias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_glossary_alias", tb => tb.HasComment("entries alias"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Entryid, "mdl_glosalia_ent_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("alias");
            entity.Property(e => e.Entryid).HasColumnName("entryid");
        });

        modelBuilder.Entity<MdlGlossaryCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_glossary_categories", tb => tb.HasComment("all categories for glossary entries"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Glossaryid, "mdl_gloscate_glo_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Glossaryid).HasColumnName("glossaryid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Usedynalink)
                .HasDefaultValueSql("'1'")
                .HasColumnName("usedynalink");
        });

        modelBuilder.Entity<MdlGlossaryEntriesCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_glossary_entries_categories", tb => tb.HasComment("categories of each glossary entry"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Categoryid, "mdl_glosentrcate_cat_ix");

            entity.HasIndex(e => e.Entryid, "mdl_glosentrcate_ent_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Entryid).HasColumnName("entryid");
        });

        modelBuilder.Entity<MdlGlossaryEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_glossary_entries", tb => tb.HasComment("all glossary entries"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Concept, "mdl_glosentr_con_ix");

            entity.HasIndex(e => e.Glossaryid, "mdl_glosentr_glo_ix");

            entity.HasIndex(e => e.Userid, "mdl_glosentr_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approved)
                .HasDefaultValueSql("'1'")
                .HasColumnName("approved");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("attachment");
            entity.Property(e => e.Casesensitive).HasColumnName("casesensitive");
            entity.Property(e => e.Concept)
                .HasDefaultValueSql("''")
                .HasColumnName("concept");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Definitionformat).HasColumnName("definitionformat");
            entity.Property(e => e.Definitiontrust).HasColumnName("definitiontrust");
            entity.Property(e => e.Fullmatch)
                .HasDefaultValueSql("'1'")
                .HasColumnName("fullmatch");
            entity.Property(e => e.Glossaryid).HasColumnName("glossaryid");
            entity.Property(e => e.Sourceglossaryid).HasColumnName("sourceglossaryid");
            entity.Property(e => e.Teacherentry).HasColumnName("teacherentry");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usedynalink)
                .HasDefaultValueSql("'1'")
                .HasColumnName("usedynalink");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlGlossaryFormat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_glossary_formats", tb => tb.HasComment("Setting of the display formats"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Defaulthook)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("defaulthook");
            entity.Property(e => e.Defaultmode)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("defaultmode");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Popupformatname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("popupformatname");
            entity.Property(e => e.Showgroup)
                .HasDefaultValueSql("'1'")
                .HasColumnName("showgroup");
            entity.Property(e => e.Showtabs)
                .HasMaxLength(100)
                .HasColumnName("showtabs");
            entity.Property(e => e.Sortkey)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("sortkey");
            entity.Property(e => e.Sortorder)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("sortorder");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlGooglemeet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_googlemeet", tb => tb.HasComment("Stores the googlemeet activity module instances."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_goog_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Addmultiply).HasColumnName("addmultiply");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Creatoremail)
                .HasMaxLength(255)
                .HasColumnName("creatoremail");
            entity.Property(e => e.Days)
                .HasMaxLength(255)
                .HasColumnName("days");
            entity.Property(e => e.Endhour).HasColumnName("endhour");
            entity.Property(e => e.Endminute).HasColumnName("endminute");
            entity.Property(e => e.Eventdate).HasColumnName("eventdate");
            entity.Property(e => e.Eventenddate).HasColumnName("eventenddate");
            entity.Property(e => e.Eventid)
                .HasMaxLength(100)
                .HasColumnName("eventid");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Lastsync).HasColumnName("lastsync");
            entity.Property(e => e.Minutesbefore).HasColumnName("minutesbefore");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Notify).HasColumnName("notify");
            entity.Property(e => e.Originalname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("originalname");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Starthour).HasColumnName("starthour");
            entity.Property(e => e.Startminute).HasColumnName("startminute");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
        });

        modelBuilder.Entity<MdlGooglemeetEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_googlemeet_events", tb => tb.HasComment("Stores the googlemeet events."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Googlemeetid, "mdl_googeven_goo_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Eventdate).HasColumnName("eventdate");
            entity.Property(e => e.Googlemeetid).HasColumnName("googlemeetid");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGooglemeetNotifyDone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_googlemeet_notify_done", tb => tb.HasComment("Stores references from Google Meet recordings."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Eventid, "mdl_goognotidone_eve_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Eventid).HasColumnName("eventid");
            entity.Property(e => e.Timesent).HasColumnName("timesent");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlGooglemeetRecording>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_googlemeet_recordings", tb => tb.HasComment("Stores references from Google Meet recordings."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Googlemeetid, "mdl_googreco_goo_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdtime).HasColumnName("createdtime");
            entity.Property(e => e.Duration)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("duration");
            entity.Property(e => e.Googlemeetid).HasColumnName("googlemeetid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Recordingid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("recordingid");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
            entity.Property(e => e.Webviewlink).HasColumnName("webviewlink");
        });

        modelBuilder.Entity<MdlGradeCategoriesHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_categories_history", tb => tb.HasComment("History of grade_categories"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Action, "mdl_gradcatehist_act_ix");

            entity.HasIndex(e => e.Courseid, "mdl_gradcatehist_cou_ix");

            entity.HasIndex(e => e.Loggeduser, "mdl_gradcatehist_log_ix");

            entity.HasIndex(e => e.Oldid, "mdl_gradcatehist_old_ix");

            entity.HasIndex(e => e.Parent, "mdl_gradcatehist_par_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_gradcatehist_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Aggregateonlygraded).HasColumnName("aggregateonlygraded");
            entity.Property(e => e.Aggregateoutcomes).HasColumnName("aggregateoutcomes");
            entity.Property(e => e.Aggregatesubcats).HasColumnName("aggregatesubcats");
            entity.Property(e => e.Aggregation).HasColumnName("aggregation");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Depth).HasColumnName("depth");
            entity.Property(e => e.Droplow).HasColumnName("droplow");
            entity.Property(e => e.Fullname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("fullname");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Keephigh).HasColumnName("keephigh");
            entity.Property(e => e.Loggeduser).HasColumnName("loggeduser");
            entity.Property(e => e.Oldid).HasColumnName("oldid");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasColumnName("path");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGradeCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_categories", tb => tb.HasComment("This table keeps information about categories, used for grou"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_gradcate_cou_ix");

            entity.HasIndex(e => e.Parent, "mdl_gradcate_par_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aggregateonlygraded).HasColumnName("aggregateonlygraded");
            entity.Property(e => e.Aggregateoutcomes).HasColumnName("aggregateoutcomes");
            entity.Property(e => e.Aggregation).HasColumnName("aggregation");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Depth).HasColumnName("depth");
            entity.Property(e => e.Droplow).HasColumnName("droplow");
            entity.Property(e => e.Fullname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("fullname");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Keephigh).HasColumnName("keephigh");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasColumnName("path");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGradeGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_grades", tb => tb.HasComment("grade_grades  This table keeps individual grades for each us"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Itemid, "mdl_gradgrad_ite_ix");

            entity.HasIndex(e => new { e.Locked, e.Locktime }, "mdl_gradgrad_locloc_ix");

            entity.HasIndex(e => e.Rawscaleid, "mdl_gradgrad_raw_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_gradgrad_use2_ix");

            entity.HasIndex(e => e.Userid, "mdl_gradgrad_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Itemid }, "mdl_gradgrad_useite_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aggregationstatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("'unknown'")
                .HasColumnName("aggregationstatus");
            entity.Property(e => e.Aggregationweight)
                .HasPrecision(10, 5)
                .HasColumnName("aggregationweight");
            entity.Property(e => e.Excluded).HasColumnName("excluded");
            entity.Property(e => e.Exported).HasColumnName("exported");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.Feedbackformat).HasColumnName("feedbackformat");
            entity.Property(e => e.Finalgrade)
                .HasPrecision(10, 5)
                .HasColumnName("finalgrade");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Information).HasColumnName("information");
            entity.Property(e => e.Informationformat).HasColumnName("informationformat");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Locktime).HasColumnName("locktime");
            entity.Property(e => e.Overridden).HasColumnName("overridden");
            entity.Property(e => e.Rawgrade)
                .HasPrecision(10, 5)
                .HasColumnName("rawgrade");
            entity.Property(e => e.Rawgrademax)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'100.00000'")
                .HasColumnName("rawgrademax");
            entity.Property(e => e.Rawgrademin)
                .HasPrecision(10, 5)
                .HasColumnName("rawgrademin");
            entity.Property(e => e.Rawscaleid).HasColumnName("rawscaleid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlGradeGradesHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_grades_history", tb => tb.HasComment("History table"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Action, "mdl_gradgradhist_act_ix");

            entity.HasIndex(e => e.Itemid, "mdl_gradgradhist_ite_ix");

            entity.HasIndex(e => e.Loggeduser, "mdl_gradgradhist_log_ix");

            entity.HasIndex(e => e.Oldid, "mdl_gradgradhist_old_ix");

            entity.HasIndex(e => e.Rawscaleid, "mdl_gradgradhist_raw_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_gradgradhist_tim_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_gradgradhist_use2_ix");

            entity.HasIndex(e => e.Userid, "mdl_gradgradhist_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Itemid, e.Timemodified }, "mdl_gradgradhist_useitetim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Excluded).HasColumnName("excluded");
            entity.Property(e => e.Exported).HasColumnName("exported");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.Feedbackformat).HasColumnName("feedbackformat");
            entity.Property(e => e.Finalgrade)
                .HasPrecision(10, 5)
                .HasColumnName("finalgrade");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Information).HasColumnName("information");
            entity.Property(e => e.Informationformat).HasColumnName("informationformat");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Locktime).HasColumnName("locktime");
            entity.Property(e => e.Loggeduser).HasColumnName("loggeduser");
            entity.Property(e => e.Oldid).HasColumnName("oldid");
            entity.Property(e => e.Overridden).HasColumnName("overridden");
            entity.Property(e => e.Rawgrade)
                .HasPrecision(10, 5)
                .HasColumnName("rawgrade");
            entity.Property(e => e.Rawgrademax)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'100.00000'")
                .HasColumnName("rawgrademax");
            entity.Property(e => e.Rawgrademin)
                .HasPrecision(10, 5)
                .HasColumnName("rawgrademin");
            entity.Property(e => e.Rawscaleid).HasColumnName("rawscaleid");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlGradeImportNewitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_import_newitem", tb => tb.HasComment("temporary table for storing new grade_item names from grade "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Importer, "mdl_gradimponewi_imp_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Importcode).HasColumnName("importcode");
            entity.Property(e => e.Importer).HasColumnName("importer");
            entity.Property(e => e.Itemname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("itemname");
        });

        modelBuilder.Entity<MdlGradeImportValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_import_values", tb => tb.HasComment("Temporary table for importing grades"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Importer, "mdl_gradimpovalu_imp_ix");

            entity.HasIndex(e => e.Itemid, "mdl_gradimpovalu_ite_ix");

            entity.HasIndex(e => e.Newgradeitem, "mdl_gradimpovalu_new_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.Finalgrade)
                .HasPrecision(10, 5)
                .HasColumnName("finalgrade");
            entity.Property(e => e.Importcode).HasColumnName("importcode");
            entity.Property(e => e.Importer).HasColumnName("importer");
            entity.Property(e => e.Importonlyfeedback)
                .HasDefaultValueSql("'0'")
                .HasColumnName("importonlyfeedback");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Newgradeitem).HasColumnName("newgradeitem");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlGradeItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_items", tb => tb.HasComment("This table keeps information about gradeable items (ie colum"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Categoryid, "mdl_graditem_cat_ix");

            entity.HasIndex(e => e.Courseid, "mdl_graditem_cou_ix");

            entity.HasIndex(e => e.Gradetype, "mdl_graditem_gra_ix");

            entity.HasIndex(e => new { e.Idnumber, e.Courseid }, "mdl_graditem_idncou_ix");

            entity.HasIndex(e => new { e.Itemtype, e.Needsupdate }, "mdl_graditem_itenee_ix");

            entity.HasIndex(e => new { e.Locked, e.Locktime }, "mdl_graditem_locloc_ix");

            entity.HasIndex(e => e.Outcomeid, "mdl_graditem_out_ix");

            entity.HasIndex(e => e.Scaleid, "mdl_graditem_sca_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aggregationcoef)
                .HasPrecision(10, 5)
                .HasColumnName("aggregationcoef");
            entity.Property(e => e.Aggregationcoef2)
                .HasPrecision(10, 5)
                .HasColumnName("aggregationcoef2");
            entity.Property(e => e.Calculation).HasColumnName("calculation");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Decimals).HasColumnName("decimals");
            entity.Property(e => e.Display).HasColumnName("display");
            entity.Property(e => e.Grademax)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'100.00000'")
                .HasColumnName("grademax");
            entity.Property(e => e.Grademin)
                .HasPrecision(10, 5)
                .HasColumnName("grademin");
            entity.Property(e => e.Gradepass)
                .HasPrecision(10, 5)
                .HasColumnName("gradepass");
            entity.Property(e => e.Gradetype)
                .HasDefaultValueSql("'1'")
                .HasColumnName("gradetype");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Idnumber).HasColumnName("idnumber");
            entity.Property(e => e.Iteminfo).HasColumnName("iteminfo");
            entity.Property(e => e.Iteminstance).HasColumnName("iteminstance");
            entity.Property(e => e.Itemmodule)
                .HasMaxLength(30)
                .HasColumnName("itemmodule");
            entity.Property(e => e.Itemname)
                .HasMaxLength(255)
                .HasColumnName("itemname");
            entity.Property(e => e.Itemnumber).HasColumnName("itemnumber");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("itemtype");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Locktime).HasColumnName("locktime");
            entity.Property(e => e.Multfactor)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'1.00000'")
                .HasColumnName("multfactor");
            entity.Property(e => e.Needsupdate).HasColumnName("needsupdate");
            entity.Property(e => e.Outcomeid).HasColumnName("outcomeid");
            entity.Property(e => e.Plusfactor)
                .HasPrecision(10, 5)
                .HasColumnName("plusfactor");
            entity.Property(e => e.Scaleid).HasColumnName("scaleid");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Weightoverride).HasColumnName("weightoverride");
        });

        modelBuilder.Entity<MdlGradeItemsHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_items_history", tb => tb.HasComment("History of grade_items"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Action, "mdl_graditemhist_act_ix");

            entity.HasIndex(e => e.Categoryid, "mdl_graditemhist_cat_ix");

            entity.HasIndex(e => e.Courseid, "mdl_graditemhist_cou_ix");

            entity.HasIndex(e => e.Loggeduser, "mdl_graditemhist_log_ix");

            entity.HasIndex(e => e.Oldid, "mdl_graditemhist_old_ix");

            entity.HasIndex(e => e.Outcomeid, "mdl_graditemhist_out_ix");

            entity.HasIndex(e => e.Scaleid, "mdl_graditemhist_sca_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_graditemhist_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Aggregationcoef)
                .HasPrecision(10, 5)
                .HasColumnName("aggregationcoef");
            entity.Property(e => e.Aggregationcoef2)
                .HasPrecision(10, 5)
                .HasColumnName("aggregationcoef2");
            entity.Property(e => e.Calculation).HasColumnName("calculation");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Decimals).HasColumnName("decimals");
            entity.Property(e => e.Display).HasColumnName("display");
            entity.Property(e => e.Grademax)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'100.00000'")
                .HasColumnName("grademax");
            entity.Property(e => e.Grademin)
                .HasPrecision(10, 5)
                .HasColumnName("grademin");
            entity.Property(e => e.Gradepass)
                .HasPrecision(10, 5)
                .HasColumnName("gradepass");
            entity.Property(e => e.Gradetype)
                .HasDefaultValueSql("'1'")
                .HasColumnName("gradetype");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(255)
                .HasColumnName("idnumber");
            entity.Property(e => e.Iteminfo).HasColumnName("iteminfo");
            entity.Property(e => e.Iteminstance).HasColumnName("iteminstance");
            entity.Property(e => e.Itemmodule)
                .HasMaxLength(30)
                .HasColumnName("itemmodule");
            entity.Property(e => e.Itemname)
                .HasMaxLength(255)
                .HasColumnName("itemname");
            entity.Property(e => e.Itemnumber).HasColumnName("itemnumber");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("itemtype");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Locktime).HasColumnName("locktime");
            entity.Property(e => e.Loggeduser).HasColumnName("loggeduser");
            entity.Property(e => e.Multfactor)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'1.00000'")
                .HasColumnName("multfactor");
            entity.Property(e => e.Needsupdate).HasColumnName("needsupdate");
            entity.Property(e => e.Oldid).HasColumnName("oldid");
            entity.Property(e => e.Outcomeid).HasColumnName("outcomeid");
            entity.Property(e => e.Plusfactor)
                .HasPrecision(10, 5)
                .HasColumnName("plusfactor");
            entity.Property(e => e.Scaleid).HasColumnName("scaleid");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Weightoverride).HasColumnName("weightoverride");
        });

        modelBuilder.Entity<MdlGradeLetter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_letters", tb => tb.HasComment("Repository for grade letters, for courses and other moodle e"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Contextid, e.Lowerboundary, e.Letter }, "mdl_gradlett_conlowlet_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Letter)
                .HasDefaultValueSql("''")
                .HasColumnName("letter");
            entity.Property(e => e.Lowerboundary)
                .HasPrecision(10, 5)
                .HasColumnName("lowerboundary");
        });

        modelBuilder.Entity<MdlGradeOutcome>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_outcomes", tb => tb.HasComment("This table describes the outcomes used in the system. An out"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_gradoutc_cou_ix");

            entity.HasIndex(e => new { e.Courseid, e.Shortname }, "mdl_gradoutc_cousho_uix").IsUnique();

            entity.HasIndex(e => e.Scaleid, "mdl_gradoutc_sca_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_gradoutc_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Fullname).HasColumnName("fullname");
            entity.Property(e => e.Scaleid).HasColumnName("scaleid");
            entity.Property(e => e.Shortname)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlGradeOutcomesCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_outcomes_courses", tb => tb.HasComment("stores what outcomes are used in what courses."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_gradoutccour_cou_ix");

            entity.HasIndex(e => new { e.Courseid, e.Outcomeid }, "mdl_gradoutccour_couout_uix").IsUnique();

            entity.HasIndex(e => e.Outcomeid, "mdl_gradoutccour_out_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Outcomeid).HasColumnName("outcomeid");
        });

        modelBuilder.Entity<MdlGradeOutcomesHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_outcomes_history", tb => tb.HasComment("History table"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Action, "mdl_gradoutchist_act_ix");

            entity.HasIndex(e => e.Courseid, "mdl_gradoutchist_cou_ix");

            entity.HasIndex(e => e.Loggeduser, "mdl_gradoutchist_log_ix");

            entity.HasIndex(e => e.Oldid, "mdl_gradoutchist_old_ix");

            entity.HasIndex(e => e.Scaleid, "mdl_gradoutchist_sca_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_gradoutchist_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Fullname).HasColumnName("fullname");
            entity.Property(e => e.Loggeduser).HasColumnName("loggeduser");
            entity.Property(e => e.Oldid).HasColumnName("oldid");
            entity.Property(e => e.Scaleid).HasColumnName("scaleid");
            entity.Property(e => e.Shortname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGradeSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grade_settings", tb => tb.HasComment("gradebook settings"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_gradsett_cou_ix");

            entity.HasIndex(e => new { e.Courseid, e.Name }, "mdl_gradsett_counam_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlGradingArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grading_areas", tb => tb.HasComment("Identifies gradable areas where advanced grading can happen."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_gradarea_con_ix");

            entity.HasIndex(e => new { e.Contextid, e.Component, e.Areaname }, "mdl_gradarea_concomare_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activemethod)
                .HasMaxLength(100)
                .HasColumnName("activemethod");
            entity.Property(e => e.Areaname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("areaname");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
        });

        modelBuilder.Entity<MdlGradingDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grading_definitions", tb => tb.HasComment("Contains the basic information about an advanced grading for"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Areaid, "mdl_graddefi_are_ix");

            entity.HasIndex(e => new { e.Areaid, e.Method }, "mdl_graddefi_aremet_uix").IsUnique();

            entity.HasIndex(e => e.Usercreated, "mdl_graddefi_use2_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_graddefi_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Areaid).HasColumnName("areaid");
            entity.Property(e => e.Copiedfromid).HasColumnName("copiedfromid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Method)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("method");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Options).HasColumnName("options");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timecopied)
                .HasDefaultValueSql("'0'")
                .HasColumnName("timecopied");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usercreated).HasColumnName("usercreated");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlGradingInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_grading_instances", tb => tb.HasComment("Grading form instance is an assessment record for one gradab"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Definitionid, "mdl_gradinst_def_ix");

            entity.HasIndex(e => e.Raterid, "mdl_gradinst_rat_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Definitionid).HasColumnName("definitionid");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.Feedbackformat).HasColumnName("feedbackformat");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Raterid).HasColumnName("raterid");
            entity.Property(e => e.Rawgrade)
                .HasPrecision(10, 5)
                .HasColumnName("rawgrade");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGradingformGuideComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_gradingform_guide_comments", tb => tb.HasComment("frequently used comments used in marking guide"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Definitionid, "mdl_gradguidcomm_def_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Definitionid).HasColumnName("definitionid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlGradingformGuideCriterion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_gradingform_guide_criteria", tb => tb.HasComment("Stores the rows of the criteria grid."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Definitionid, "mdl_gradguidcrit_def_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Definitionid).HasColumnName("definitionid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Descriptionmarkers).HasColumnName("descriptionmarkers");
            entity.Property(e => e.Descriptionmarkersformat).HasColumnName("descriptionmarkersformat");
            entity.Property(e => e.Maxscore)
                .HasPrecision(10, 5)
                .HasColumnName("maxscore");
            entity.Property(e => e.Shortname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlGradingformGuideFilling>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_gradingform_guide_fillings", tb => tb.HasComment("Stores the data of how the guide is filled by a particular r"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Criterionid, "mdl_gradguidfill_cri_ix");

            entity.HasIndex(e => e.Instanceid, "mdl_gradguidfill_ins_ix");

            entity.HasIndex(e => new { e.Instanceid, e.Criterionid }, "mdl_gradguidfill_inscri_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Criterionid).HasColumnName("criterionid");
            entity.Property(e => e.Instanceid).HasColumnName("instanceid");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Remarkformat).HasColumnName("remarkformat");
            entity.Property(e => e.Score)
                .HasPrecision(10, 5)
                .HasColumnName("score");
        });

        modelBuilder.Entity<MdlGradingformRubricCriterion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_gradingform_rubric_criteria", tb => tb.HasComment("Stores the rows of the rubric grid."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Definitionid, "mdl_gradrubrcrit_def_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Definitionid).HasColumnName("definitionid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlGradingformRubricFilling>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_gradingform_rubric_fillings", tb => tb.HasComment("Stores the data of how the rubric is filled by a particular "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Criterionid, "mdl_gradrubrfill_cri_ix");

            entity.HasIndex(e => e.Instanceid, "mdl_gradrubrfill_ins_ix");

            entity.HasIndex(e => new { e.Instanceid, e.Criterionid }, "mdl_gradrubrfill_inscri_uix").IsUnique();

            entity.HasIndex(e => e.Levelid, "mdl_gradrubrfill_lev_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Criterionid).HasColumnName("criterionid");
            entity.Property(e => e.Instanceid).HasColumnName("instanceid");
            entity.Property(e => e.Levelid).HasColumnName("levelid");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Remarkformat).HasColumnName("remarkformat");
        });

        modelBuilder.Entity<MdlGradingformRubricLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_gradingform_rubric_levels", tb => tb.HasComment("Stores the columns of the rubric grid."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Criterionid, "mdl_gradrubrleve_cri_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Criterionid).HasColumnName("criterionid");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Definitionformat).HasColumnName("definitionformat");
            entity.Property(e => e.Score)
                .HasPrecision(10, 5)
                .HasColumnName("score");
        });

        modelBuilder.Entity<MdlGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_groups", tb => tb.HasComment("Each record represents a group."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_grou_cou_ix");

            entity.HasIndex(e => e.Idnumber, "mdl_grou_idn_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Enrolmentkey)
                .HasMaxLength(50)
                .HasColumnName("enrolmentkey");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("idnumber");
            entity.Property(e => e.Name)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Picture).HasColumnName("picture");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGrouping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_groupings", tb => tb.HasComment("A grouping is a collection of groups. WAS: groups_groupings"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_grou_cou2_ix");

            entity.HasIndex(e => e.Idnumber, "mdl_grou_idn2_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Configdata).HasColumnName("configdata");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("idnumber");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGroupingsGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_groupings_groups", tb => tb.HasComment("Link a grouping to a group (note, groups can be in multiple "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Groupid, "mdl_grougrou_gro2_ix");

            entity.HasIndex(e => e.Groupingid, "mdl_grougrou_gro_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Groupingid).HasColumnName("groupingid");
            entity.Property(e => e.Timeadded).HasColumnName("timeadded");
        });

        modelBuilder.Entity<MdlGroupsMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_groups_members", tb => tb.HasComment("Link a user to a group."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Groupid, "mdl_groumemb_gro_ix");

            entity.HasIndex(e => e.Userid, "mdl_groumemb_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Groupid }, "mdl_groumemb_usegro_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Timeadded).HasColumnName("timeadded");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlH5p>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_h5p")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Mainlibraryid, "mdl_h5p_mai_ix");

            entity.HasIndex(e => e.Pathnamehash, "mdl_h5p_pat_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contenthash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("contenthash");
            entity.Property(e => e.Displayoptions).HasColumnName("displayoptions");
            entity.Property(e => e.Filtered).HasColumnName("filtered");
            entity.Property(e => e.Jsoncontent).HasColumnName("jsoncontent");
            entity.Property(e => e.Mainlibraryid).HasColumnName("mainlibraryid");
            entity.Property(e => e.Pathnamehash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("pathnamehash");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlH5pContentsLibrary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_h5p_contents_libraries")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.H5pid, "mdl_h5pcontlibr_h5p_ix");

            entity.HasIndex(e => e.Libraryid, "mdl_h5pcontlibr_lib_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dependencytype)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("dependencytype");
            entity.Property(e => e.Dropcss).HasColumnName("dropcss");
            entity.Property(e => e.H5pid).HasColumnName("h5pid");
            entity.Property(e => e.Libraryid).HasColumnName("libraryid");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<MdlH5pLibrariesCachedasset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_h5p_libraries_cachedassets")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Libraryid, "mdl_h5plibrcach_lib_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Hash)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("hash");
            entity.Property(e => e.Libraryid).HasColumnName("libraryid");
        });

        modelBuilder.Entity<MdlH5pLibrary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_h5p_libraries")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Machinename, e.Majorversion, e.Minorversion, e.Patchversion, e.Runnable }, "mdl_h5plibr_macmajminpatrun_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Addto).HasColumnName("addto");
            entity.Property(e => e.Coremajor).HasColumnName("coremajor");
            entity.Property(e => e.Coreminor).HasColumnName("coreminor");
            entity.Property(e => e.Droplibrarycss).HasColumnName("droplibrarycss");
            entity.Property(e => e.Embedtypes)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("embedtypes");
            entity.Property(e => e.Enabled)
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabled");
            entity.Property(e => e.Example).HasColumnName("example");
            entity.Property(e => e.Fullscreen).HasColumnName("fullscreen");
            entity.Property(e => e.Machinename)
                .HasDefaultValueSql("''")
                .HasColumnName("machinename");
            entity.Property(e => e.Majorversion).HasColumnName("majorversion");
            entity.Property(e => e.Metadatasettings).HasColumnName("metadatasettings");
            entity.Property(e => e.Minorversion).HasColumnName("minorversion");
            entity.Property(e => e.Patchversion).HasColumnName("patchversion");
            entity.Property(e => e.Preloadedcss).HasColumnName("preloadedcss");
            entity.Property(e => e.Preloadedjs).HasColumnName("preloadedjs");
            entity.Property(e => e.Runnable).HasColumnName("runnable");
            entity.Property(e => e.Semantics).HasColumnName("semantics");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.Tutorial).HasColumnName("tutorial");
        });

        modelBuilder.Entity<MdlH5pLibraryDependency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_h5p_library_dependencies")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Libraryid, "mdl_h5plibrdepe_lib_ix");

            entity.HasIndex(e => e.Requiredlibraryid, "mdl_h5plibrdepe_req_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dependencytype)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("dependencytype");
            entity.Property(e => e.Libraryid).HasColumnName("libraryid");
            entity.Property(e => e.Requiredlibraryid).HasColumnName("requiredlibraryid");
        });

        modelBuilder.Entity<MdlH5pactivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_h5pactivity", tb => tb.HasComment("Stores the h5pactivity activity module instances."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_h5pa_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Displayoptions).HasColumnName("displayoptions");
            entity.Property(e => e.Enabletracking)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabletracking");
            entity.Property(e => e.Grade)
                .HasDefaultValueSql("'0'")
                .HasColumnName("grade");
            entity.Property(e => e.Grademethod)
                .HasDefaultValueSql("'1'")
                .HasColumnName("grademethod");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Reviewmode)
                .HasDefaultValueSql("'1'")
                .HasColumnName("reviewmode");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlH5pactivityAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_h5pactivity_attempts", tb => tb.HasComment("Users attempts inside H5P activities"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.H5pactivityid, "mdl_h5paatte_h5p_ix");

            entity.HasIndex(e => new { e.H5pactivityid, e.Timecreated }, "mdl_h5paatte_h5ptim_ix");

            entity.HasIndex(e => new { e.H5pactivityid, e.Userid }, "mdl_h5paatte_h5puse_ix");

            entity.HasIndex(e => new { e.H5pactivityid, e.Userid, e.Attempt }, "mdl_h5paatte_h5puseatt_uix").IsUnique();

            entity.HasIndex(e => e.Timecreated, "mdl_h5paatte_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attempt)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("attempt");
            entity.Property(e => e.Completion).HasColumnName("completion");
            entity.Property(e => e.Duration)
                .HasDefaultValueSql("'0'")
                .HasColumnName("duration");
            entity.Property(e => e.H5pactivityid).HasColumnName("h5pactivityid");
            entity.Property(e => e.Maxscore)
                .HasDefaultValueSql("'0'")
                .HasColumnName("maxscore");
            entity.Property(e => e.Rawscore)
                .HasDefaultValueSql("'0'")
                .HasColumnName("rawscore");
            entity.Property(e => e.Scaled)
                .HasPrecision(10, 5)
                .HasColumnName("scaled");
            entity.Property(e => e.Success).HasColumnName("success");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlH5pactivityAttemptsResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_h5pactivity_attempts_results", tb => tb.HasComment("H5Pactivities_attempts tracking info"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Attemptid, "mdl_h5paatteresu_att_ix");

            entity.HasIndex(e => new { e.Attemptid, e.Timecreated }, "mdl_h5paatteresu_atttim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Additionals).HasColumnName("additionals");
            entity.Property(e => e.Attemptid).HasColumnName("attemptid");
            entity.Property(e => e.Completion).HasColumnName("completion");
            entity.Property(e => e.Correctpattern).HasColumnName("correctpattern");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Duration)
                .HasDefaultValueSql("'0'")
                .HasColumnName("duration");
            entity.Property(e => e.Interactiontype)
                .HasMaxLength(128)
                .HasColumnName("interactiontype");
            entity.Property(e => e.Maxscore).HasColumnName("maxscore");
            entity.Property(e => e.Rawscore).HasColumnName("rawscore");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.Subcontent)
                .HasMaxLength(128)
                .HasColumnName("subcontent");
            entity.Property(e => e.Success).HasColumnName("success");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlImscp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_imscp", tb => tb.HasComment("each record is one imscp resource"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_imsc_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Keepold)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("keepold");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Revision).HasColumnName("revision");
            entity.Property(e => e.Structure).HasColumnName("structure");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlInfectedFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_infected_files")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Userid, "mdl_infefile_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Filename).HasColumnName("filename");
            entity.Property(e => e.Quarantinedfile).HasColumnName("quarantinedfile");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLabel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_label", tb => tb.HasComment("Defines labels"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_labe_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlLesson>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lesson", tb => tb.HasComment("Defines lesson"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_less_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activitylink).HasColumnName("activitylink");
            entity.Property(e => e.Allowofflineattempts)
                .HasDefaultValueSql("'0'")
                .HasColumnName("allowofflineattempts");
            entity.Property(e => e.Available).HasColumnName("available");
            entity.Property(e => e.Bgcolor)
                .HasMaxLength(7)
                .HasDefaultValueSql("'#FFFFFF'")
                .HasColumnName("bgcolor");
            entity.Property(e => e.Completionendreached)
                .HasDefaultValueSql("'0'")
                .HasColumnName("completionendreached");
            entity.Property(e => e.Completiontimespent)
                .HasDefaultValueSql("'0'")
                .HasColumnName("completiontimespent");
            entity.Property(e => e.Conditions).HasColumnName("conditions");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Custom).HasColumnName("custom");
            entity.Property(e => e.Deadline).HasColumnName("deadline");
            entity.Property(e => e.Dependency).HasColumnName("dependency");
            entity.Property(e => e.Displayleft).HasColumnName("displayleft");
            entity.Property(e => e.Displayleftif).HasColumnName("displayleftif");
            entity.Property(e => e.Feedback)
                .HasDefaultValueSql("'1'")
                .HasColumnName("feedback");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Height)
                .HasDefaultValueSql("'480'")
                .HasColumnName("height");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Maxanswers)
                .HasDefaultValueSql("'4'")
                .HasColumnName("maxanswers");
            entity.Property(e => e.Maxattempts)
                .HasDefaultValueSql("'5'")
                .HasColumnName("maxattempts");
            entity.Property(e => e.Maxpages).HasColumnName("maxpages");
            entity.Property(e => e.Mediaclose).HasColumnName("mediaclose");
            entity.Property(e => e.Mediafile)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("mediafile");
            entity.Property(e => e.Mediaheight)
                .HasDefaultValueSql("'100'")
                .HasColumnName("mediaheight");
            entity.Property(e => e.Mediawidth)
                .HasDefaultValueSql("'650'")
                .HasColumnName("mediawidth");
            entity.Property(e => e.Minquestions).HasColumnName("minquestions");
            entity.Property(e => e.Modattempts).HasColumnName("modattempts");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Nextpagedefault).HasColumnName("nextpagedefault");
            entity.Property(e => e.Ongoing).HasColumnName("ongoing");
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("password");
            entity.Property(e => e.Practice).HasColumnName("practice");
            entity.Property(e => e.Progressbar).HasColumnName("progressbar");
            entity.Property(e => e.Retake)
                .HasDefaultValueSql("'1'")
                .HasColumnName("retake");
            entity.Property(e => e.Review).HasColumnName("review");
            entity.Property(e => e.Slideshow).HasColumnName("slideshow");
            entity.Property(e => e.Timelimit).HasColumnName("timelimit");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usemaxgrade).HasColumnName("usemaxgrade");
            entity.Property(e => e.Usepassword).HasColumnName("usepassword");
            entity.Property(e => e.Width)
                .HasDefaultValueSql("'640'")
                .HasColumnName("width");
        });

        modelBuilder.Entity<MdlLessonAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lesson_answers", tb => tb.HasComment("Defines lesson_answers"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Lessonid, "mdl_lessansw_les_ix");

            entity.HasIndex(e => e.Pageid, "mdl_lessansw_pag_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Answerformat).HasColumnName("answerformat");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Jumpto).HasColumnName("jumpto");
            entity.Property(e => e.Lessonid).HasColumnName("lessonid");
            entity.Property(e => e.Pageid).HasColumnName("pageid");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.Responseformat).HasColumnName("responseformat");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlLessonAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lesson_attempts", tb => tb.HasComment("Defines lesson_attempts"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Answerid, "mdl_lessatte_ans_ix");

            entity.HasIndex(e => e.Lessonid, "mdl_lessatte_les_ix");

            entity.HasIndex(e => e.Pageid, "mdl_lessatte_pag_ix");

            entity.HasIndex(e => e.Userid, "mdl_lessatte_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answerid).HasColumnName("answerid");
            entity.Property(e => e.Correct).HasColumnName("correct");
            entity.Property(e => e.Lessonid).HasColumnName("lessonid");
            entity.Property(e => e.Pageid).HasColumnName("pageid");
            entity.Property(e => e.Retry).HasColumnName("retry");
            entity.Property(e => e.Timeseen).HasColumnName("timeseen");
            entity.Property(e => e.Useranswer).HasColumnName("useranswer");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLessonBranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lesson_branch", tb => tb.HasComment("branches for each lesson/user"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Lessonid, "mdl_lessbran_les_ix");

            entity.HasIndex(e => e.Pageid, "mdl_lessbran_pag_ix");

            entity.HasIndex(e => e.Userid, "mdl_lessbran_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Flag).HasColumnName("flag");
            entity.Property(e => e.Lessonid).HasColumnName("lessonid");
            entity.Property(e => e.Nextpageid).HasColumnName("nextpageid");
            entity.Property(e => e.Pageid).HasColumnName("pageid");
            entity.Property(e => e.Retry).HasColumnName("retry");
            entity.Property(e => e.Timeseen).HasColumnName("timeseen");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLessonGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lesson_grades", tb => tb.HasComment("Defines lesson_grades"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Lessonid, "mdl_lessgrad_les_ix");

            entity.HasIndex(e => e.Userid, "mdl_lessgrad_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Completed).HasColumnName("completed");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Late).HasColumnName("late");
            entity.Property(e => e.Lessonid).HasColumnName("lessonid");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLessonOverride>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lesson_overrides", tb => tb.HasComment("The overrides to lesson settings."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Groupid, "mdl_lessover_gro_ix");

            entity.HasIndex(e => e.Lessonid, "mdl_lessover_les_ix");

            entity.HasIndex(e => e.Userid, "mdl_lessover_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Available).HasColumnName("available");
            entity.Property(e => e.Deadline).HasColumnName("deadline");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Lessonid).HasColumnName("lessonid");
            entity.Property(e => e.Maxattempts).HasColumnName("maxattempts");
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .HasColumnName("password");
            entity.Property(e => e.Retake).HasColumnName("retake");
            entity.Property(e => e.Review).HasColumnName("review");
            entity.Property(e => e.Timelimit).HasColumnName("timelimit");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLessonPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lesson_pages", tb => tb.HasComment("Defines lesson_pages"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Lessonid, "mdl_lesspage_les_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contents).HasColumnName("contents");
            entity.Property(e => e.Contentsformat).HasColumnName("contentsformat");
            entity.Property(e => e.Display)
                .HasDefaultValueSql("'1'")
                .HasColumnName("display");
            entity.Property(e => e.Layout)
                .HasDefaultValueSql("'1'")
                .HasColumnName("layout");
            entity.Property(e => e.Lessonid).HasColumnName("lessonid");
            entity.Property(e => e.Nextpageid).HasColumnName("nextpageid");
            entity.Property(e => e.Prevpageid).HasColumnName("prevpageid");
            entity.Property(e => e.Qoption).HasColumnName("qoption");
            entity.Property(e => e.Qtype).HasColumnName("qtype");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        modelBuilder.Entity<MdlLessonTimer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lesson_timer", tb => tb.HasComment("lesson timer for each lesson"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Lessonid, "mdl_lesstime_les_ix");

            entity.HasIndex(e => e.Userid, "mdl_lesstime_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Completed)
                .HasDefaultValueSql("'0'")
                .HasColumnName("completed");
            entity.Property(e => e.Lessonid).HasColumnName("lessonid");
            entity.Property(e => e.Lessontime).HasColumnName("lessontime");
            entity.Property(e => e.Starttime).HasColumnName("starttime");
            entity.Property(e => e.Timemodifiedoffline).HasColumnName("timemodifiedoffline");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLicense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_license", tb => tb.HasComment("store licenses used by moodle"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Custom).HasColumnName("custom");
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabled");
            entity.Property(e => e.Fullname).HasColumnName("fullname");
            entity.Property(e => e.Shortname)
                .HasMaxLength(255)
                .HasColumnName("shortname");
            entity.Property(e => e.Sortorder)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("sortorder");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<MdlLockDb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lock_db", tb => tb.HasComment("Stores active and inactive lock types for db locking method."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Expires, "mdl_lockdb_exp_ix");

            entity.HasIndex(e => e.Owner, "mdl_lockdb_own_ix");

            entity.HasIndex(e => e.Resourcekey, "mdl_lockdb_res_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Expires).HasColumnName("expires");
            entity.Property(e => e.Owner)
                .HasMaxLength(36)
                .HasColumnName("owner");
            entity.Property(e => e.Resourcekey)
                .HasDefaultValueSql("''")
                .HasColumnName("resourcekey");
        });

        modelBuilder.Entity<MdlLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_log", tb => tb.HasComment("Every action is logged as far as possible"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Action, "mdl_log_act_ix");

            entity.HasIndex(e => e.Cmid, "mdl_log_cmi_ix");

            entity.HasIndex(e => new { e.Course, e.Module, e.Action }, "mdl_log_coumodact_ix");

            entity.HasIndex(e => e.Time, "mdl_log_tim_ix");

            entity.HasIndex(e => new { e.Userid, e.Course }, "mdl_log_usecou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Cmid).HasColumnName("cmid");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Info)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("info");
            entity.Property(e => e.Ip)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ip");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("module");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLogDisplay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_log_display", tb => tb.HasComment("For a particular module/action, specifies a moodle table/fie"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Module, e.Action }, "mdl_logdisp_modact_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Field)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("field");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("module");
            entity.Property(e => e.Mtable)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("mtable");
        });

        modelBuilder.Entity<MdlLogQuery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_log_queries", tb => tb.HasComment("Logged database queries."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Backtrace).HasColumnName("backtrace");
            entity.Property(e => e.Error)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("error");
            entity.Property(e => e.Exectime)
                .HasPrecision(10, 5)
                .HasColumnName("exectime");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Qtype)
                .HasColumnType("mediumint")
                .HasColumnName("qtype");
            entity.Property(e => e.Sqlparams).HasColumnName("sqlparams");
            entity.Property(e => e.Sqltext).HasColumnName("sqltext");
            entity.Property(e => e.Timelogged).HasColumnName("timelogged");
        });

        modelBuilder.Entity<MdlLogstoreStandardLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_logstore_standard_log", tb => tb.HasComment("Standard log table"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Timecreated, e.Objecttable, e.Userid, e.Courseid }, "mdl_logsstanlog_analytics");

            entity.HasIndex(e => e.Contextid, "mdl_logsstanlog_con_ix");

            entity.HasIndex(e => new { e.Courseid, e.Anonymous, e.Timecreated }, "mdl_logsstanlog_couanotim_ix");

            entity.HasIndex(e => e.Timecreated, "mdl_logsstanlog_tim_ix");

            entity.HasIndex(e => new { e.Userid, e.Contextlevel, e.Contextinstanceid, e.Crud, e.Edulevel, e.Timecreated }, "mdl_logsstanlog_useconconcr_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Anonymous).HasColumnName("anonymous");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Contextinstanceid).HasColumnName("contextinstanceid");
            entity.Property(e => e.Contextlevel).HasColumnName("contextlevel");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Crud)
                .HasMaxLength(1)
                .HasDefaultValueSql("''")
                .HasColumnName("crud");
            entity.Property(e => e.Edulevel).HasColumnName("edulevel");
            entity.Property(e => e.Eventname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("eventname");
            entity.Property(e => e.Ip)
                .HasMaxLength(45)
                .HasColumnName("ip");
            entity.Property(e => e.Objectid).HasColumnName("objectid");
            entity.Property(e => e.Objecttable)
                .HasMaxLength(50)
                .HasColumnName("objecttable");
            entity.Property(e => e.Origin)
                .HasMaxLength(10)
                .HasColumnName("origin");
            entity.Property(e => e.Other).HasColumnName("other");
            entity.Property(e => e.Realuserid).HasColumnName("realuserid");
            entity.Property(e => e.Relateduserid).HasColumnName("relateduserid");
            entity.Property(e => e.Target)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("target");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLti>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lti", tb => tb.HasComment("This table contains Basic LTI activities instances"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_lti_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Debuglaunch).HasColumnName("debuglaunch");
            entity.Property(e => e.Grade)
                .HasDefaultValueSql("'100'")
                .HasColumnName("grade");
            entity.Property(e => e.Icon).HasColumnName("icon");
            entity.Property(e => e.Instructorchoiceacceptgrades).HasColumnName("instructorchoiceacceptgrades");
            entity.Property(e => e.Instructorchoiceallowroster).HasColumnName("instructorchoiceallowroster");
            entity.Property(e => e.Instructorchoiceallowsetting).HasColumnName("instructorchoiceallowsetting");
            entity.Property(e => e.Instructorchoicesendemailaddr).HasColumnName("instructorchoicesendemailaddr");
            entity.Property(e => e.Instructorchoicesendname).HasColumnName("instructorchoicesendname");
            entity.Property(e => e.Instructorcustomparameters).HasColumnName("instructorcustomparameters");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("introformat");
            entity.Property(e => e.Launchcontainer)
                .HasDefaultValueSql("'1'")
                .HasColumnName("launchcontainer");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Resourcekey)
                .HasMaxLength(255)
                .HasColumnName("resourcekey");
            entity.Property(e => e.Secureicon).HasColumnName("secureicon");
            entity.Property(e => e.Securetoolurl).HasColumnName("securetoolurl");
            entity.Property(e => e.Servicesalt)
                .HasMaxLength(40)
                .HasColumnName("servicesalt");
            entity.Property(e => e.Showdescriptionlaunch).HasColumnName("showdescriptionlaunch");
            entity.Property(e => e.Showtitlelaunch).HasColumnName("showtitlelaunch");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Toolurl).HasColumnName("toolurl");
            entity.Property(e => e.Typeid).HasColumnName("typeid");
        });

        modelBuilder.Entity<MdlLtiAccessToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lti_access_tokens")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Token, "mdl_ltiaccetoke_tok_uix").IsUnique();

            entity.HasIndex(e => e.Typeid, "mdl_ltiaccetoke_typ_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lastaccess).HasColumnName("lastaccess");
            entity.Property(e => e.Scope).HasColumnName("scope");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Token)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("token");
            entity.Property(e => e.Typeid).HasColumnName("typeid");
            entity.Property(e => e.Validuntil).HasColumnName("validuntil");
        });

        modelBuilder.Entity<MdlLtiSubmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lti_submission", tb => tb.HasComment("Keeps track of individual submissions for LTI activities."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Ltiid, "mdl_ltisubm_lti_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datesubmitted).HasColumnName("datesubmitted");
            entity.Property(e => e.Dateupdated).HasColumnName("dateupdated");
            entity.Property(e => e.Gradepercent)
                .HasPrecision(10, 5)
                .HasColumnName("gradepercent");
            entity.Property(e => e.Launchid).HasColumnName("launchid");
            entity.Property(e => e.Ltiid).HasColumnName("ltiid");
            entity.Property(e => e.Originalgrade)
                .HasPrecision(10, 5)
                .HasColumnName("originalgrade");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLtiToolProxy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lti_tool_proxies", tb => tb.HasComment("LTI tool proxy registrations"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Guid, "mdl_ltitoolprox_gui_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capabilityoffered).HasColumnName("capabilityoffered");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("'Tool Provider'")
                .HasColumnName("name");
            entity.Property(e => e.Regurl).HasColumnName("regurl");
            entity.Property(e => e.Secret)
                .HasMaxLength(255)
                .HasColumnName("secret");
            entity.Property(e => e.Serviceoffered).HasColumnName("serviceoffered");
            entity.Property(e => e.State)
                .HasDefaultValueSql("'1'")
                .HasColumnName("state");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Toolproxy).HasColumnName("toolproxy");
            entity.Property(e => e.Vendorcode)
                .HasMaxLength(255)
                .HasColumnName("vendorcode");
        });

        modelBuilder.Entity<MdlLtiToolSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lti_tool_settings", tb => tb.HasComment("LTI tool setting values"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Coursemoduleid, "mdl_ltitoolsett_cou2_ix");

            entity.HasIndex(e => e.Course, "mdl_ltitoolsett_cou_ix");

            entity.HasIndex(e => e.Toolproxyid, "mdl_ltitoolsett_too_ix");

            entity.HasIndex(e => e.Typeid, "mdl_ltitoolsett_typ_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Coursemoduleid).HasColumnName("coursemoduleid");
            entity.Property(e => e.Settings).HasColumnName("settings");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Toolproxyid).HasColumnName("toolproxyid");
            entity.Property(e => e.Typeid).HasColumnName("typeid");
        });

        modelBuilder.Entity<MdlLtiType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lti_types", tb => tb.HasComment("Basic LTI pre-configured activities"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Clientid, "mdl_ltitype_cli_uix").IsUnique();

            entity.HasIndex(e => e.Course, "mdl_ltitype_cou_ix");

            entity.HasIndex(e => e.Tooldomain, "mdl_ltitype_too_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Baseurl).HasColumnName("baseurl");
            entity.Property(e => e.Clientid).HasColumnName("clientid");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Coursevisible).HasColumnName("coursevisible");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Enabledcapability).HasColumnName("enabledcapability");
            entity.Property(e => e.Icon).HasColumnName("icon");
            entity.Property(e => e.Ltiversion)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("ltiversion");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("'basiclti Activity'")
                .HasColumnName("name");
            entity.Property(e => e.Parameter).HasColumnName("parameter");
            entity.Property(e => e.Secureicon).HasColumnName("secureicon");
            entity.Property(e => e.State)
                .HasDefaultValueSql("'2'")
                .HasColumnName("state");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Tooldomain)
                .HasDefaultValueSql("''")
                .HasColumnName("tooldomain");
            entity.Property(e => e.Toolproxyid).HasColumnName("toolproxyid");
        });

        modelBuilder.Entity<MdlLtiTypesConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_lti_types_config", tb => tb.HasComment("Basic LTI types configuration"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Typeid, "mdl_ltitypeconf_typ_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Typeid).HasColumnName("typeid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlLtiserviceGradebookservice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_ltiservice_gradebookservices", tb => tb.HasComment("This file records the grade items created by the LTI Gradebo"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Gradeitemid, e.Courseid }, "mdl_ltisgrad_gracou_ix");

            entity.HasIndex(e => e.Ltilinkid, "mdl_ltisgrad_lti_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Baseurl).HasColumnName("baseurl");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Gradeitemid).HasColumnName("gradeitemid");
            entity.Property(e => e.Ltilinkid).HasColumnName("ltilinkid");
            entity.Property(e => e.Resourceid)
                .HasMaxLength(512)
                .HasColumnName("resourceid");
            entity.Property(e => e.Tag)
                .HasMaxLength(255)
                .HasColumnName("tag");
            entity.Property(e => e.Toolproxyid).HasColumnName("toolproxyid");
            entity.Property(e => e.Typeid).HasColumnName("typeid");
        });

        modelBuilder.Entity<MdlMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message", tb => tb.HasComment("Stores all unread messages"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Useridto, e.Timeusertodeleted, e.Notification }, "mdl_mess_usetimnot2_ix");

            entity.HasIndex(e => new { e.Useridfrom, e.Timeuserfromdeleted, e.Notification }, "mdl_mess_usetimnot_ix");

            entity.HasIndex(e => new { e.Useridfrom, e.Useridto, e.Timeuserfromdeleted, e.Timeusertodeleted }, "mdl_mess_useusetimtim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Contexturl).HasColumnName("contexturl");
            entity.Property(e => e.Contexturlname).HasColumnName("contexturlname");
            entity.Property(e => e.Customdata).HasColumnName("customdata");
            entity.Property(e => e.Eventtype)
                .HasMaxLength(100)
                .HasColumnName("eventtype");
            entity.Property(e => e.Fullmessage).HasColumnName("fullmessage");
            entity.Property(e => e.Fullmessageformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("fullmessageformat");
            entity.Property(e => e.Fullmessagehtml).HasColumnName("fullmessagehtml");
            entity.Property(e => e.Notification)
                .HasDefaultValueSql("'0'")
                .HasColumnName("notification");
            entity.Property(e => e.Smallmessage).HasColumnName("smallmessage");
            entity.Property(e => e.Subject).HasColumnName("subject");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timeuserfromdeleted).HasColumnName("timeuserfromdeleted");
            entity.Property(e => e.Timeusertodeleted).HasColumnName("timeusertodeleted");
            entity.Property(e => e.Useridfrom).HasColumnName("useridfrom");
            entity.Property(e => e.Useridto).HasColumnName("useridto");
        });

        modelBuilder.Entity<MdlMessage1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_messages", tb => tb.HasComment("Stores all messages"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Conversationid, "mdl_mess_con_ix");

            entity.HasIndex(e => new { e.Conversationid, e.Timecreated }, "mdl_mess_contim_ix");

            entity.HasIndex(e => e.Useridfrom, "mdl_mess_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Conversationid).HasColumnName("conversationid");
            entity.Property(e => e.Customdata).HasColumnName("customdata");
            entity.Property(e => e.Fullmessage).HasColumnName("fullmessage");
            entity.Property(e => e.Fullmessageformat).HasColumnName("fullmessageformat");
            entity.Property(e => e.Fullmessagehtml).HasColumnName("fullmessagehtml");
            entity.Property(e => e.Fullmessagetrust).HasColumnName("fullmessagetrust");
            entity.Property(e => e.Smallmessage).HasColumnName("smallmessage");
            entity.Property(e => e.Subject).HasColumnName("subject");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Useridfrom).HasColumnName("useridfrom");
        });

        modelBuilder.Entity<MdlMessageAirnotifierDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_airnotifier_devices", tb => tb.HasComment("Store information about the devices registered in Airnotifie"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Userdeviceid, "mdl_messairndevi_use_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Enable)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enable");
            entity.Property(e => e.Userdeviceid).HasColumnName("userdeviceid");
        });

        modelBuilder.Entity<MdlMessageContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_contacts", tb => tb.HasComment("Maintains lists of contacts between users"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contactid, "mdl_messcont_con_ix");

            entity.HasIndex(e => e.Userid, "mdl_messcont_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Contactid }, "mdl_messcont_usecon_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contactid).HasColumnName("contactid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMessageContactRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_contact_requests", tb => tb.HasComment("Maintains list of contact requests between users"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Requesteduserid, "mdl_messcontrequ_req_ix");

            entity.HasIndex(e => e.Userid, "mdl_messcontrequ_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Requesteduserid }, "mdl_messcontrequ_usereq_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Requesteduserid).HasColumnName("requesteduserid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMessageConversation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_conversations", tb => tb.HasComment("Stores all message conversations"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Component, e.Itemtype, e.Itemid, e.Contextid }, "mdl_messconv_comiteitecon_ix");

            entity.HasIndex(e => e.Contextid, "mdl_messconv_con2_ix");

            entity.HasIndex(e => e.Convhash, "mdl_messconv_con_ix");

            entity.HasIndex(e => e.Type, "mdl_messconv_typ_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Convhash)
                .HasMaxLength(40)
                .HasColumnName("convhash");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(100)
                .HasColumnName("itemtype");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'1'")
                .HasColumnName("type");
        });

        modelBuilder.Entity<MdlMessageConversationAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_conversation_actions")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Conversationid, "mdl_messconvacti_con_ix");

            entity.HasIndex(e => e.Userid, "mdl_messconvacti_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Conversationid).HasColumnName("conversationid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMessageConversationMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_conversation_members", tb => tb.HasComment("Stores all members in a conversations"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Conversationid, "mdl_messconvmemb_con_ix");

            entity.HasIndex(e => e.Userid, "mdl_messconvmemb_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Conversationid).HasColumnName("conversationid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMessageEmailMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_email_messages")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Conversationid, "mdl_messemaimess_con_ix");

            entity.HasIndex(e => e.Messageid, "mdl_messemaimess_mes_ix");

            entity.HasIndex(e => e.Useridto, "mdl_messemaimess_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Conversationid).HasColumnName("conversationid");
            entity.Property(e => e.Messageid).HasColumnName("messageid");
            entity.Property(e => e.Useridto).HasColumnName("useridto");
        });

        modelBuilder.Entity<MdlMessagePopup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_popup", tb => tb.HasComment("Keep state of notifications for the popup message processor"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Isread, "mdl_messpopu_isr_ix");

            entity.HasIndex(e => new { e.Messageid, e.Isread }, "mdl_messpopu_mesisr_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Isread).HasColumnName("isread");
            entity.Property(e => e.Messageid).HasColumnName("messageid");
        });

        modelBuilder.Entity<MdlMessagePopupNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_popup_notifications", tb => tb.HasComment("List of notifications to display in the message output popup"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Notificationid, "mdl_messpopunoti_not_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Notificationid).HasColumnName("notificationid");
        });

        modelBuilder.Entity<MdlMessageProcessor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_processors", tb => tb.HasComment("List of message output plugins"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(166)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<MdlMessageProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_providers", tb => tb.HasComment("This table stores the message providers (modules and core sy"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Component, e.Name }, "mdl_messprov_comnam_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capability)
                .HasMaxLength(255)
                .HasColumnName("capability");
            entity.Property(e => e.Component)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<MdlMessageRead>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_read", tb => tb.HasComment("Stores all messages that have been read"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Notification, e.Timeread }, "mdl_messread_nottim_ix");

            entity.HasIndex(e => new { e.Useridto, e.Timeusertodeleted, e.Notification }, "mdl_messread_usetimnot2_ix");

            entity.HasIndex(e => new { e.Useridfrom, e.Timeuserfromdeleted, e.Notification }, "mdl_messread_usetimnot_ix");

            entity.HasIndex(e => new { e.Useridfrom, e.Useridto, e.Timeuserfromdeleted, e.Timeusertodeleted }, "mdl_messread_useusetimtim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Contexturl).HasColumnName("contexturl");
            entity.Property(e => e.Contexturlname).HasColumnName("contexturlname");
            entity.Property(e => e.Eventtype)
                .HasMaxLength(100)
                .HasColumnName("eventtype");
            entity.Property(e => e.Fullmessage).HasColumnName("fullmessage");
            entity.Property(e => e.Fullmessageformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("fullmessageformat");
            entity.Property(e => e.Fullmessagehtml).HasColumnName("fullmessagehtml");
            entity.Property(e => e.Notification)
                .HasDefaultValueSql("'0'")
                .HasColumnName("notification");
            entity.Property(e => e.Smallmessage).HasColumnName("smallmessage");
            entity.Property(e => e.Subject).HasColumnName("subject");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timeread).HasColumnName("timeread");
            entity.Property(e => e.Timeuserfromdeleted).HasColumnName("timeuserfromdeleted");
            entity.Property(e => e.Timeusertodeleted).HasColumnName("timeusertodeleted");
            entity.Property(e => e.Useridfrom).HasColumnName("useridfrom");
            entity.Property(e => e.Useridto).HasColumnName("useridto");
        });

        modelBuilder.Entity<MdlMessageUserAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_user_actions", tb => tb.HasComment("Stores all per-user actions on individual messages"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Messageid, "mdl_messuseracti_mes_ix");

            entity.HasIndex(e => e.Userid, "mdl_messuseracti_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Messageid, e.Action }, "mdl_messuseracti_usemesact_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Messageid).HasColumnName("messageid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMessageUsersBlocked>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_message_users_blocked", tb => tb.HasComment("Maintains lists of blocked users"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Blockeduserid, "mdl_messuserbloc_blo_ix");

            entity.HasIndex(e => e.Userid, "mdl_messuserbloc_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Blockeduserid }, "mdl_messuserbloc_useblo_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Blockeduserid).HasColumnName("blockeduserid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMessageinboundDatakey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_messageinbound_datakeys", tb => tb.HasComment("Inbound Message data item secret keys."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Handler, "mdl_messdata_han_ix");

            entity.HasIndex(e => new { e.Handler, e.Datavalue }, "mdl_messdata_handat_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datakey)
                .HasMaxLength(64)
                .HasColumnName("datakey");
            entity.Property(e => e.Datavalue).HasColumnName("datavalue");
            entity.Property(e => e.Expires).HasColumnName("expires");
            entity.Property(e => e.Handler).HasColumnName("handler");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlMessageinboundHandler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_messageinbound_handlers", tb => tb.HasComment("Inbound Message Handler definitions."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Classname, "mdl_messhand_cla_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Classname)
                .HasDefaultValueSql("''")
                .HasColumnName("classname");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Defaultexpiration)
                .HasDefaultValueSql("'86400'")
                .HasColumnName("defaultexpiration");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Validateaddress)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("validateaddress");
        });

        modelBuilder.Entity<MdlMessageinboundMessagelist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_messageinbound_messagelist", tb => tb.HasComment("A list of message IDs for existing replies"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Userid, "mdl_messmess_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Messageid).HasColumnName("messageid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMnetApplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnet_application", tb => tb.HasComment("Information about applications on remote hosts"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("display_name");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.SsoJumpUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("sso_jump_url");
            entity.Property(e => e.SsoLandUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("sso_land_url");
            entity.Property(e => e.XmlrpcServerUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("xmlrpc_server_url");
        });

        modelBuilder.Entity<MdlMnetHost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnet_host", tb => tb.HasComment("Information about the local and remote hosts for RPC"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Applicationid, "mdl_mnethost_app_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Applicationid)
                .HasDefaultValueSql("'1'")
                .HasColumnName("applicationid");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.ForceTheme).HasColumnName("force_theme");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ip_address");
            entity.Property(e => e.LastConnectTime).HasColumnName("last_connect_time");
            entity.Property(e => e.LastLogId).HasColumnName("last_log_id");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Portno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("portno");
            entity.Property(e => e.PublicKey).HasColumnName("public_key");
            entity.Property(e => e.PublicKeyExpires).HasColumnName("public_key_expires");
            entity.Property(e => e.Sslverification).HasColumnName("sslverification");
            entity.Property(e => e.Theme)
                .HasMaxLength(100)
                .HasColumnName("theme");
            entity.Property(e => e.Transport).HasColumnName("transport");
            entity.Property(e => e.Wwwroot)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("wwwroot");
        });

        modelBuilder.Entity<MdlMnetHost2service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnet_host2service", tb => tb.HasComment("Information about the services for a given host"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Hostid, e.Serviceid }, "mdl_mnethost_hosser_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Hostid).HasColumnName("hostid");
            entity.Property(e => e.Publish).HasColumnName("publish");
            entity.Property(e => e.Serviceid).HasColumnName("serviceid");
            entity.Property(e => e.Subscribe).HasColumnName("subscribe");
        });

        modelBuilder.Entity<MdlMnetLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnet_log", tb => tb.HasComment("Store session data from users migrating to other sites"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Hostid, e.Userid, e.Course }, "mdl_mnetlog_hosusecou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Cmid).HasColumnName("cmid");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Coursename)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("coursename");
            entity.Property(e => e.Hostid).HasColumnName("hostid");
            entity.Property(e => e.Info)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("info");
            entity.Property(e => e.Ip)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ip");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("module");
            entity.Property(e => e.Remoteid).HasColumnName("remoteid");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMnetRemoteRpc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnet_remote_rpc", tb => tb.HasComment("This table describes functions that might be called remotely"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Functionname)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("functionname");
            entity.Property(e => e.Pluginname)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("pluginname");
            entity.Property(e => e.Plugintype)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("plugintype");
            entity.Property(e => e.Xmlrpcpath)
                .HasMaxLength(80)
                .HasDefaultValueSql("''")
                .HasColumnName("xmlrpcpath");
        });

        modelBuilder.Entity<MdlMnetRemoteService2rpc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnet_remote_service2rpc", tb => tb.HasComment("Group functions or methods under a service"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Rpcid, e.Serviceid }, "mdl_mnetremoserv_rpcser_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Rpcid).HasColumnName("rpcid");
            entity.Property(e => e.Serviceid).HasColumnName("serviceid");
        });

        modelBuilder.Entity<MdlMnetRpc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnet_rpc", tb => tb.HasComment("Functions or methods that we may publish or subscribe to"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Enabled, e.Xmlrpcpath }, "mdl_mnetrpc_enaxml_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Classname)
                .HasMaxLength(150)
                .HasColumnName("classname");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("filename");
            entity.Property(e => e.Functionname)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("functionname");
            entity.Property(e => e.Help).HasColumnName("help");
            entity.Property(e => e.Pluginname)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("pluginname");
            entity.Property(e => e.Plugintype)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("plugintype");
            entity.Property(e => e.Profile).HasColumnName("profile");
            entity.Property(e => e.Static).HasColumnName("static");
            entity.Property(e => e.Xmlrpcpath)
                .HasMaxLength(80)
                .HasDefaultValueSql("''")
                .HasColumnName("xmlrpcpath");
        });

        modelBuilder.Entity<MdlMnetService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnet_service", tb => tb.HasComment("A service is a group of functions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apiversion)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("apiversion");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Offer).HasColumnName("offer");
        });

        modelBuilder.Entity<MdlMnetService2rpc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnet_service2rpc", tb => tb.HasComment("Group functions or methods under a service"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Rpcid, e.Serviceid }, "mdl_mnetserv_rpcser_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Rpcid).HasColumnName("rpcid");
            entity.Property(e => e.Serviceid).HasColumnName("serviceid");
        });

        modelBuilder.Entity<MdlMnetSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnet_session", tb => tb.HasComment("Store session data from users migrating to other sites"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Token, "mdl_mnetsess_tok_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConfirmTimeout).HasColumnName("confirm_timeout");
            entity.Property(e => e.Expires).HasColumnName("expires");
            entity.Property(e => e.Mnethostid).HasColumnName("mnethostid");
            entity.Property(e => e.SessionId)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("session_id");
            entity.Property(e => e.Token)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("token");
            entity.Property(e => e.Useragent)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("useragent");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<MdlMnetSsoAccessControl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnet_sso_access_control", tb => tb.HasComment("Users by host permitted (or not) to login from a remote prov"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.MnetHostId, e.Username }, "mdl_mnetssoaccecont_mneuse_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accessctrl)
                .HasMaxLength(20)
                .HasDefaultValueSql("'allow'")
                .HasColumnName("accessctrl");
            entity.Property(e => e.MnetHostId).HasColumnName("mnet_host_id");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<MdlMnetserviceEnrolCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnetservice_enrol_courses", tb => tb.HasComment("Caches the information fetched via XML-RPC about courses on "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Hostid, e.Remoteid }, "mdl_mnetenrocour_hosrem_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("categoryname");
            entity.Property(e => e.Fullname)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("fullname");
            entity.Property(e => e.Hostid).HasColumnName("hostid");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("idnumber");
            entity.Property(e => e.Remoteid).HasColumnName("remoteid");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Rolename)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("rolename");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("summaryformat");
        });

        modelBuilder.Entity<MdlMnetserviceEnrolEnrolment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_mnetservice_enrol_enrolments", tb => tb.HasComment("Caches the information about enrolments of our local users i"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Hostid, "mdl_mnetenroenro_hos_ix");

            entity.HasIndex(e => e.Userid, "mdl_mnetenroenro_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Enroltime).HasColumnName("enroltime");
            entity.Property(e => e.Enroltype)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("enroltype");
            entity.Property(e => e.Hostid).HasColumnName("hostid");
            entity.Property(e => e.Remotecourseid).HasColumnName("remotecourseid");
            entity.Property(e => e.Rolename)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("rolename");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_modules", tb => tb.HasComment("modules available in the site"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "mdl_modu_nam_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cron).HasColumnName("cron");
            entity.Property(e => e.Lastcron).HasColumnName("lastcron");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Search)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("search");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlMyPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_my_pages", tb => tb.HasComment("Extra user pages for the My Moodle system"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Userid, e.Private }, "mdl_mypage_usepri_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Private)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("private");
            entity.Property(e => e.Sortorder)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("sortorder");
            entity.Property(e => e.Userid)
                .HasDefaultValueSql("'0'")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_notifications", tb => tb.HasComment("Stores all notifications"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Useridto, "mdl_noti_use2_ix");

            entity.HasIndex(e => e.Useridfrom, "mdl_noti_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Contexturl).HasColumnName("contexturl");
            entity.Property(e => e.Contexturlname).HasColumnName("contexturlname");
            entity.Property(e => e.Customdata).HasColumnName("customdata");
            entity.Property(e => e.Eventtype)
                .HasMaxLength(100)
                .HasColumnName("eventtype");
            entity.Property(e => e.Fullmessage).HasColumnName("fullmessage");
            entity.Property(e => e.Fullmessageformat).HasColumnName("fullmessageformat");
            entity.Property(e => e.Fullmessagehtml).HasColumnName("fullmessagehtml");
            entity.Property(e => e.Smallmessage).HasColumnName("smallmessage");
            entity.Property(e => e.Subject).HasColumnName("subject");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timeread).HasColumnName("timeread");
            entity.Property(e => e.Useridfrom).HasColumnName("useridfrom");
            entity.Property(e => e.Useridto).HasColumnName("useridto");
        });

        modelBuilder.Entity<MdlOauth2AccessToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_oauth2_access_token", tb => tb.HasComment("Stores access tokens for system accounts in order to be able"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Issuerid, "mdl_oautaccetoke_iss_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Expires).HasColumnName("expires");
            entity.Property(e => e.Issuerid).HasColumnName("issuerid");
            entity.Property(e => e.Scope).HasColumnName("scope");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlOauth2Endpoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_oauth2_endpoint", tb => tb.HasComment("Describes the named endpoint for an oauth2 service."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Issuerid, "mdl_oautendp_iss_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Issuerid).HasColumnName("issuerid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Url).HasColumnName("url");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlOauth2Issuer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_oauth2_issuer", tb => tb.HasComment("Details for an oauth 2 connect identity issuer."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alloweddomains).HasColumnName("alloweddomains");
            entity.Property(e => e.Baseurl).HasColumnName("baseurl");
            entity.Property(e => e.Basicauth).HasColumnName("basicauth");
            entity.Property(e => e.Clientid).HasColumnName("clientid");
            entity.Property(e => e.Clientsecret).HasColumnName("clientsecret");
            entity.Property(e => e.Enabled)
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabled");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Loginpagename)
                .HasMaxLength(255)
                .HasColumnName("loginpagename");
            entity.Property(e => e.Loginparams).HasColumnName("loginparams");
            entity.Property(e => e.Loginparamsoffline).HasColumnName("loginparamsoffline");
            entity.Property(e => e.Loginscopes).HasColumnName("loginscopes");
            entity.Property(e => e.Loginscopesoffline).HasColumnName("loginscopesoffline");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Requireconfirmation)
                .HasDefaultValueSql("'1'")
                .HasColumnName("requireconfirmation");
            entity.Property(e => e.Scopessupported).HasColumnName("scopessupported");
            entity.Property(e => e.Servicetype)
                .HasMaxLength(255)
                .HasColumnName("servicetype");
            entity.Property(e => e.Showonloginpage)
                .HasDefaultValueSql("'1'")
                .HasColumnName("showonloginpage");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlOauth2RefreshToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_oauth2_refresh_token")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Issuerid, "mdl_oautrefrtoke_iss_ix");

            entity.HasIndex(e => e.Userid, "mdl_oautrefrtoke_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Issuerid, e.Scopehash }, "mdl_oautrefrtoke_useisssco_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Issuerid).HasColumnName("issuerid");
            entity.Property(e => e.Scopehash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("scopehash");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlOauth2SystemAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_oauth2_system_account", tb => tb.HasComment("Stored details used to get an access token as a system user "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Issuerid, "mdl_oautsystacco_iss_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Grantedscopes).HasColumnName("grantedscopes");
            entity.Property(e => e.Issuerid).HasColumnName("issuerid");
            entity.Property(e => e.Refreshtoken).HasColumnName("refreshtoken");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
            entity.Property(e => e.Username).HasColumnName("username");
        });

        modelBuilder.Entity<MdlOauth2UserFieldMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_oauth2_user_field_mapping", tb => tb.HasComment("Mapping of oauth user fields to moodle fields."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Issuerid, "mdl_oautuserfielmapp_iss_ix");

            entity.HasIndex(e => new { e.Issuerid, e.Internalfield }, "mdl_oautuserfielmapp_issin_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Externalfield)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("externalfield");
            entity.Property(e => e.Internalfield)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("internalfield");
            entity.Property(e => e.Issuerid).HasColumnName("issuerid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_page", tb => tb.HasComment("Each record is one page and its config data"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_page_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Contentformat).HasColumnName("contentformat");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Display).HasColumnName("display");
            entity.Property(e => e.Displayoptions).HasColumnName("displayoptions");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Legacyfiles).HasColumnName("legacyfiles");
            entity.Property(e => e.Legacyfileslast).HasColumnName("legacyfileslast");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Revision).HasColumnName("revision");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlPaygwPaypal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_paygw_paypal", tb => tb.HasComment("Stores PayPal related information"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Paymentid, "mdl_paygpayp_pay_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Paymentid).HasColumnName("paymentid");
            entity.Property(e => e.PpOrderid)
                .HasMaxLength(255)
                .HasDefaultValueSql("'The ID of the order in PayPal'")
                .HasColumnName("pp_orderid");
        });

        modelBuilder.Entity<MdlPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_payments")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Accountid, "mdl_paym_acc_ix");

            entity.HasIndex(e => new { e.Component, e.Paymentarea, e.Itemid }, "mdl_paym_compayite_ix");

            entity.HasIndex(e => e.Gateway, "mdl_paym_gat_ix");

            entity.HasIndex(e => e.Userid, "mdl_paym_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accountid).HasColumnName("accountid");
            entity.Property(e => e.Amount)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("amount");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("currency");
            entity.Property(e => e.Gateway)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("gateway");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Paymentarea)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("paymentarea");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlPaymentAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_payment_accounts")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlPaymentGateway>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_payment_gateways")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Accountid, "mdl_paymgate_acc_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accountid).HasColumnName("accountid");
            entity.Property(e => e.Config).HasColumnName("config");
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabled");
            entity.Property(e => e.Gateway)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("gateway");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlPlagiarismTurnitinConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_plagiarism_turnitin_config", tb => tb.HasComment("info about plugin config"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Cm, "mdl_plagturnconf_cm_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cm).HasColumnName("cm");
            entity.Property(e => e.ConfigHash)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("config_hash");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlPlagiarismTurnitinCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_plagiarism_turnitin_courses", tb => tb.HasComment("Turnitin Plagiarism Plugin Courses"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_plagturncour_cou_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.TurnitinCid).HasColumnName("turnitin_cid");
            entity.Property(e => e.TurnitinCtl).HasColumnName("turnitin_ctl");
        });

        modelBuilder.Entity<MdlPlagiarismTurnitinFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_plagiarism_turnitin_files", tb => tb.HasComment("info about submitted files"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Cm, "mdl_plagturnfile_cm_ix");

            entity.HasIndex(e => e.Externalid, "mdl_plagturnfile_ext_ix");

            entity.HasIndex(e => e.Userid, "mdl_plagturnfile_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attempt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("attempt");
            entity.Property(e => e.Cm).HasColumnName("cm");
            entity.Property(e => e.DuedateReportRefresh).HasColumnName("duedate_report_refresh");
            entity.Property(e => e.Errorcode).HasColumnName("errorcode");
            entity.Property(e => e.Errormsg).HasColumnName("errormsg");
            entity.Property(e => e.Externalid).HasColumnName("externalid");
            entity.Property(e => e.GmFeedback).HasColumnName("gm_feedback");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Identifier)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("identifier");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Lastmodified)
                .HasDefaultValueSql("'0'")
                .HasColumnName("lastmodified");
            entity.Property(e => e.Orcapable).HasColumnName("orcapable");
            entity.Property(e => e.Similarityscore).HasColumnName("similarityscore");
            entity.Property(e => e.Statuscode)
                .HasMaxLength(10)
                .HasColumnName("statuscode");
            entity.Property(e => e.StudentRead).HasColumnName("student_read");
            entity.Property(e => e.Submissiontype).HasColumnName("submissiontype");
            entity.Property(e => e.Submitter).HasColumnName("submitter");
            entity.Property(e => e.Transmatch)
                .HasDefaultValueSql("'0'")
                .HasColumnName("transmatch");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlPlagiarismTurnitinPeermark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_plagiarism_turnitin_peermark", tb => tb.HasComment("Turnitin Plagiarism Peermark Assignments"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.ParentTiiAssignId, "mdl_plagturnpeer_par_ix");

            entity.HasIndex(e => e.Tiiassignid, "mdl_plagturnpeer_tii_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dtdue).HasColumnName("dtdue");
            entity.Property(e => e.Dtpost).HasColumnName("dtpost");
            entity.Property(e => e.Dtstart).HasColumnName("dtstart");
            entity.Property(e => e.Maxmarks).HasColumnName("maxmarks");
            entity.Property(e => e.ParentTiiAssignId).HasColumnName("parent_tii_assign_id");
            entity.Property(e => e.Tiiassignid).HasColumnName("tiiassignid");
            entity.Property(e => e.Title).HasColumnName("title");
        });

        modelBuilder.Entity<MdlPlagiarismTurnitinUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_plagiarism_turnitin_users", tb => tb.HasComment("Plagiarism Plugin Users"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Userid, "mdl_plagturnuser_use_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InstructorRubrics).HasColumnName("instructor_rubrics");
            entity.Property(e => e.TurnitinUid).HasColumnName("turnitin_uid");
            entity.Property(e => e.TurnitinUtp)
                .HasDefaultValueSql("'0'")
                .HasColumnName("turnitin_utp");
            entity.Property(e => e.UserAgreementAccepted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("user_agreement_accepted");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlPortfolioInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_portfolio_instance", tb => tb.HasComment("base table (not including config data) for instances of port"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Plugin)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("plugin");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlPortfolioInstanceConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_portfolio_instance_config", tb => tb.HasComment("config for portfolio plugin instances"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Instance, "mdl_portinstconf_ins_ix");

            entity.HasIndex(e => e.Name, "mdl_portinstconf_nam_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Instance).HasColumnName("instance");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlPortfolioInstanceUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_portfolio_instance_user", tb => tb.HasComment("user data for portfolio instances."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Instance, "mdl_portinstuser_ins_ix");

            entity.HasIndex(e => e.Userid, "mdl_portinstuser_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Instance).HasColumnName("instance");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlPortfolioLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_portfolio_log", tb => tb.HasComment("log of portfolio transfers (used to later check for duplicat"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Portfolio, "mdl_portlog_por_ix");

            entity.HasIndex(e => e.Userid, "mdl_portlog_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CallerClass)
                .HasMaxLength(150)
                .HasDefaultValueSql("''")
                .HasColumnName("caller_class");
            entity.Property(e => e.CallerComponent)
                .HasMaxLength(255)
                .HasColumnName("caller_component");
            entity.Property(e => e.CallerFile)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("caller_file");
            entity.Property(e => e.CallerSha1)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("caller_sha1");
            entity.Property(e => e.Continueurl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("continueurl");
            entity.Property(e => e.Portfolio).HasColumnName("portfolio");
            entity.Property(e => e.Returnurl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("returnurl");
            entity.Property(e => e.Tempdataid).HasColumnName("tempdataid");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlPortfolioMaharaQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_portfolio_mahara_queue", tb => tb.HasComment("maps mahara tokens to transfer ids"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Token, "mdl_portmahaqueu_tok_ix");

            entity.HasIndex(e => e.Transferid, "mdl_portmahaqueu_tra_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Token)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("token");
            entity.Property(e => e.Transferid).HasColumnName("transferid");
        });

        modelBuilder.Entity<MdlPortfolioTempdatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_portfolio_tempdata", tb => tb.HasComment("stores temporary data for portfolio exports. the id of this "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Instance, "mdl_porttemp_ins_ix");

            entity.HasIndex(e => e.Userid, "mdl_porttemp_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Expirytime).HasColumnName("expirytime");
            entity.Property(e => e.Instance)
                .HasDefaultValueSql("'0'")
                .HasColumnName("instance");
            entity.Property(e => e.Queued).HasColumnName("queued");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_post", tb => tb.HasComment("Generic post table to hold data blog entries etc in differen"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Id, e.Userid }, "mdl_post_iduse_uix").IsUnique();

            entity.HasIndex(e => e.Lastmodified, "mdl_post_las_ix");

            entity.HasIndex(e => e.Module, "mdl_post_mod_ix");

            entity.HasIndex(e => e.Subject, "mdl_post_sub_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_post_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .HasColumnName("attachment");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Coursemoduleid).HasColumnName("coursemoduleid");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.Format).HasColumnName("format");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("module");
            entity.Property(e => e.Moduleid).HasColumnName("moduleid");
            entity.Property(e => e.Publishstate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'draft'")
                .HasColumnName("publishstate");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.Subject)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("subject");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat).HasColumnName("summaryformat");
            entity.Property(e => e.Uniquehash)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("uniquehash");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlProfiling>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_profiling", tb => tb.HasComment("Stores the results of all the profiling runs"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Runid, "mdl_prof_run_uix").IsUnique();

            entity.HasIndex(e => new { e.Timecreated, e.Runreference }, "mdl_prof_timrun_ix");

            entity.HasIndex(e => new { e.Url, e.Runreference }, "mdl_prof_urlrun_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Runcomment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("runcomment");
            entity.Property(e => e.Runid)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("runid");
            entity.Property(e => e.Runreference).HasColumnName("runreference");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Totalcalls).HasColumnName("totalcalls");
            entity.Property(e => e.Totalcputime).HasColumnName("totalcputime");
            entity.Property(e => e.Totalexecutiontime).HasColumnName("totalexecutiontime");
            entity.Property(e => e.Totalmemory).HasColumnName("totalmemory");
            entity.Property(e => e.Url)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
        });

        modelBuilder.Entity<MdlQtypeDdimageortext>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_qtype_ddimageortext", tb => tb.HasComment("Defines drag and drop (text or images onto a background imag"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_qtypddim_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat).HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat).HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat).HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect).HasColumnName("shownumcorrect");
            entity.Property(e => e.Shuffleanswers)
                .HasDefaultValueSql("'1'")
                .HasColumnName("shuffleanswers");
        });

        modelBuilder.Entity<MdlQtypeDdimageortextDrag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_qtype_ddimageortext_drags", tb => tb.HasComment("Images to drag. Actual file names are not stored here we use"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_qtypddimdrag_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Draggroup).HasColumnName("draggroup");
            entity.Property(e => e.Infinite).HasColumnName("infinite");
            entity.Property(e => e.Label).HasColumnName("label");
            entity.Property(e => e.No).HasColumnName("no");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
        });

        modelBuilder.Entity<MdlQtypeDdimageortextDrop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_qtype_ddimageortext_drops", tb => tb.HasComment("Drop boxes"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_qtypddimdrop_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Choice).HasColumnName("choice");
            entity.Property(e => e.Label).HasColumnName("label");
            entity.Property(e => e.No).HasColumnName("no");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Xleft).HasColumnName("xleft");
            entity.Property(e => e.Ytop).HasColumnName("ytop");
        });

        modelBuilder.Entity<MdlQtypeDdmarker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_qtype_ddmarker", tb => tb.HasComment("Defines drag and drop (text or images onto a background imag"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_qtypddma_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat).HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat).HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat).HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Showmisplaced).HasColumnName("showmisplaced");
            entity.Property(e => e.Shownumcorrect).HasColumnName("shownumcorrect");
            entity.Property(e => e.Shuffleanswers)
                .HasDefaultValueSql("'1'")
                .HasColumnName("shuffleanswers");
        });

        modelBuilder.Entity<MdlQtypeDdmarkerDrag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_qtype_ddmarker_drags", tb => tb.HasComment("Labels for markers to drag."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_qtypddmadrag_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Infinite).HasColumnName("infinite");
            entity.Property(e => e.Label).HasColumnName("label");
            entity.Property(e => e.No).HasColumnName("no");
            entity.Property(e => e.Noofdrags)
                .HasDefaultValueSql("'1'")
                .HasColumnName("noofdrags");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
        });

        modelBuilder.Entity<MdlQtypeDdmarkerDrop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_qtype_ddmarker_drops", tb => tb.HasComment("drop regions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_qtypddmadrop_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Choice).HasColumnName("choice");
            entity.Property(e => e.Coords).HasColumnName("coords");
            entity.Property(e => e.No).HasColumnName("no");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Shape)
                .HasMaxLength(255)
                .HasColumnName("shape");
        });

        modelBuilder.Entity<MdlQtypeEssayOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_qtype_essay_options", tb => tb.HasComment("Extra options for essay questions."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_qtypessaopti_que_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attachments).HasColumnName("attachments");
            entity.Property(e => e.Attachmentsrequired).HasColumnName("attachmentsrequired");
            entity.Property(e => e.Filetypeslist).HasColumnName("filetypeslist");
            entity.Property(e => e.Graderinfo).HasColumnName("graderinfo");
            entity.Property(e => e.Graderinfoformat).HasColumnName("graderinfoformat");
            entity.Property(e => e.Maxbytes).HasColumnName("maxbytes");
            entity.Property(e => e.Maxwordlimit).HasColumnName("maxwordlimit");
            entity.Property(e => e.Minwordlimit).HasColumnName("minwordlimit");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Responsefieldlines)
                .HasDefaultValueSql("'15'")
                .HasColumnName("responsefieldlines");
            entity.Property(e => e.Responseformat)
                .HasMaxLength(16)
                .HasDefaultValueSql("'editor'")
                .HasColumnName("responseformat");
            entity.Property(e => e.Responserequired)
                .HasDefaultValueSql("'1'")
                .HasColumnName("responserequired");
            entity.Property(e => e.Responsetemplate).HasColumnName("responsetemplate");
            entity.Property(e => e.Responsetemplateformat).HasColumnName("responsetemplateformat");
        });

        modelBuilder.Entity<MdlQtypeMatchOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_qtype_match_options", tb => tb.HasComment("Defines the question-type specific options for matching ques"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_qtypmatcopti_que_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat).HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat).HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat).HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect).HasColumnName("shownumcorrect");
            entity.Property(e => e.Shuffleanswers)
                .HasDefaultValueSql("'1'")
                .HasColumnName("shuffleanswers");
        });

        modelBuilder.Entity<MdlQtypeMatchSubquestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_qtype_match_subquestions", tb => tb.HasComment("The subquestions that make up a matching question"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_qtypmatcsubq_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answertext)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("answertext");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Questiontext).HasColumnName("questiontext");
            entity.Property(e => e.Questiontextformat).HasColumnName("questiontextformat");
        });

        modelBuilder.Entity<MdlQtypeMultichoiceOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_qtype_multichoice_options", tb => tb.HasComment("Options for multiple choice questions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_qtypmultopti_que_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answernumbering)
                .HasMaxLength(10)
                .HasDefaultValueSql("'abc'")
                .HasColumnName("answernumbering");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat).HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat).HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Layout).HasColumnName("layout");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat).HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect).HasColumnName("shownumcorrect");
            entity.Property(e => e.Showstandardinstruction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("showstandardinstruction");
            entity.Property(e => e.Shuffleanswers)
                .HasDefaultValueSql("'1'")
                .HasColumnName("shuffleanswers");
            entity.Property(e => e.Single).HasColumnName("single");
        });

        modelBuilder.Entity<MdlQtypeRandomsamatchOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_qtype_randomsamatch_options", tb => tb.HasComment("Info about a random short-answer matching question"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_qtyprandopti_que_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Choose)
                .HasDefaultValueSql("'4'")
                .HasColumnName("choose");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat).HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat).HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat).HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect).HasColumnName("shownumcorrect");
            entity.Property(e => e.Subcats)
                .HasDefaultValueSql("'1'")
                .HasColumnName("subcats");
        });

        modelBuilder.Entity<MdlQtypeShortanswerOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_qtype_shortanswer_options", tb => tb.HasComment("Options for short answer questions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_qtypshoropti_que_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Usecase).HasColumnName("usecase");
        });

        modelBuilder.Entity<MdlQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question", tb => tb.HasComment("The questions themselves"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Category, "mdl_ques_cat_ix");

            entity.HasIndex(e => new { e.Category, e.Idnumber }, "mdl_ques_catidn_uix").IsUnique();

            entity.HasIndex(e => e.Createdby, "mdl_ques_cre_ix");

            entity.HasIndex(e => e.Modifiedby, "mdl_ques_mod_ix");

            entity.HasIndex(e => e.Parent, "mdl_ques_par_ix");

            entity.HasIndex(e => e.Qtype, "mdl_ques_qty_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Defaultmark)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'1.0000000'")
                .HasColumnName("defaultmark");
            entity.Property(e => e.Generalfeedback).HasColumnName("generalfeedback");
            entity.Property(e => e.Generalfeedbackformat).HasColumnName("generalfeedbackformat");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Length)
                .HasDefaultValueSql("'1'")
                .HasColumnName("length");
            entity.Property(e => e.Modifiedby).HasColumnName("modifiedby");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Penalty)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'0.3333333'")
                .HasColumnName("penalty");
            entity.Property(e => e.Qtype)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("qtype");
            entity.Property(e => e.Questiontext).HasColumnName("questiontext");
            entity.Property(e => e.Questiontextformat).HasColumnName("questiontextformat");
            entity.Property(e => e.Stamp)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("stamp");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlQuestionAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_answers", tb => tb.HasComment("Answers, with a fractional grade (0-1) and feedback"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Question, "mdl_quesansw_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Answerformat).HasColumnName("answerformat");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.Feedbackformat).HasColumnName("feedbackformat");
            entity.Property(e => e.Fraction)
                .HasPrecision(12, 7)
                .HasColumnName("fraction");
            entity.Property(e => e.Question).HasColumnName("question");
        });

        modelBuilder.Entity<MdlQuestionAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_attempts", tb => tb.HasComment("Each row here corresponds to an attempt at one question, as "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Behaviour, "mdl_quesatte_beh_ix");

            entity.HasIndex(e => e.Questionusageid, "mdl_quesatte_que2_ix");

            entity.HasIndex(e => e.Questionid, "mdl_quesatte_que_ix");

            entity.HasIndex(e => new { e.Questionusageid, e.Slot }, "mdl_quesatte_queslo_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Behaviour)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("behaviour");
            entity.Property(e => e.Flagged).HasColumnName("flagged");
            entity.Property(e => e.Maxfraction)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'1.0000000'")
                .HasColumnName("maxfraction");
            entity.Property(e => e.Maxmark)
                .HasPrecision(12, 7)
                .HasColumnName("maxmark");
            entity.Property(e => e.Minfraction)
                .HasPrecision(12, 7)
                .HasColumnName("minfraction");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Questionsummary).HasColumnName("questionsummary");
            entity.Property(e => e.Questionusageid).HasColumnName("questionusageid");
            entity.Property(e => e.Responsesummary).HasColumnName("responsesummary");
            entity.Property(e => e.Rightanswer).HasColumnName("rightanswer");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Variant)
                .HasDefaultValueSql("'1'")
                .HasColumnName("variant");
        });

        modelBuilder.Entity<MdlQuestionAttemptStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_attempt_steps", tb => tb.HasComment("Stores one step in in a question attempt. As well as the dat"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionattemptid, "mdl_quesattestep_que_ix");

            entity.HasIndex(e => new { e.Questionattemptid, e.Sequencenumber }, "mdl_quesattestep_queseq_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_quesattestep_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fraction)
                .HasPrecision(12, 7)
                .HasColumnName("fraction");
            entity.Property(e => e.Questionattemptid).HasColumnName("questionattemptid");
            entity.Property(e => e.Sequencenumber).HasColumnName("sequencenumber");
            entity.Property(e => e.State)
                .HasMaxLength(13)
                .HasDefaultValueSql("''")
                .HasColumnName("state");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlQuestionAttemptStepDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_attempt_step_data", tb => tb.HasComment("Each question_attempt_step has an associative array of the d"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Attemptstepid, "mdl_quesattestepdata_att_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attemptstepid).HasColumnName("attemptstepid");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlQuestionCalculated>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_calculated", tb => tb.HasComment("Options for questions of type calculated"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Answer, "mdl_quescalc_ans_ix");

            entity.HasIndex(e => e.Question, "mdl_quescalc_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Correctanswerformat)
                .HasDefaultValueSql("'2'")
                .HasColumnName("correctanswerformat");
            entity.Property(e => e.Correctanswerlength)
                .HasDefaultValueSql("'2'")
                .HasColumnName("correctanswerlength");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Tolerance)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0.0'")
                .HasColumnName("tolerance");
            entity.Property(e => e.Tolerancetype)
                .HasDefaultValueSql("'1'")
                .HasColumnName("tolerancetype");
        });

        modelBuilder.Entity<MdlQuestionCalculatedOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_calculated_options", tb => tb.HasComment("Options for questions of type calculated"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Question, "mdl_quescalcopti_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answernumbering)
                .HasMaxLength(10)
                .HasDefaultValueSql("'abc'")
                .HasColumnName("answernumbering");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat).HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat).HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat).HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Shownumcorrect).HasColumnName("shownumcorrect");
            entity.Property(e => e.Shuffleanswers).HasColumnName("shuffleanswers");
            entity.Property(e => e.Single).HasColumnName("single");
            entity.Property(e => e.Synchronize).HasColumnName("synchronize");
        });

        modelBuilder.Entity<MdlQuestionCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_categories", tb => tb.HasComment("Categories are for grouping questions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_quescate_con_ix");

            entity.HasIndex(e => new { e.Contextid, e.Idnumber }, "mdl_quescate_conidn_uix").IsUnique();

            entity.HasIndex(e => new { e.Contextid, e.Stamp }, "mdl_quescate_consta_uix").IsUnique();

            entity.HasIndex(e => e.Parent, "mdl_quescate_par_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Infoformat).HasColumnName("infoformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Sortorder)
                .HasDefaultValueSql("'999'")
                .HasColumnName("sortorder");
            entity.Property(e => e.Stamp)
                .HasDefaultValueSql("''")
                .HasColumnName("stamp");
        });

        modelBuilder.Entity<MdlQuestionDataset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_datasets", tb => tb.HasComment("Many-many relation between questions and dataset definitions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Datasetdefinition, "mdl_quesdata_dat_ix");

            entity.HasIndex(e => e.Question, "mdl_quesdata_que_ix");

            entity.HasIndex(e => new { e.Question, e.Datasetdefinition }, "mdl_quesdata_quedat_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datasetdefinition).HasColumnName("datasetdefinition");
            entity.Property(e => e.Question).HasColumnName("question");
        });

        modelBuilder.Entity<MdlQuestionDatasetDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_dataset_definitions", tb => tb.HasComment("Organises and stores properties for dataset items"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Category, "mdl_quesdatadefi_cat_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Itemcount).HasColumnName("itemcount");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Options)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("options");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<MdlQuestionDatasetItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_dataset_items", tb => tb.HasComment("Individual dataset items"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Definition, "mdl_quesdataitem_def_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Itemnumber).HasColumnName("itemnumber");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlQuestionDdwto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_ddwtos", tb => tb.HasComment("Defines drag and drop (words into sentences) questions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_quesddwt_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat).HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat).HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat).HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect).HasColumnName("shownumcorrect");
            entity.Property(e => e.Shuffleanswers)
                .HasDefaultValueSql("'1'")
                .HasColumnName("shuffleanswers");
        });

        modelBuilder.Entity<MdlQuestionGapselect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_gapselect", tb => tb.HasComment("Defines select missing words questions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_quesgaps_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat).HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat).HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat).HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect).HasColumnName("shownumcorrect");
            entity.Property(e => e.Shuffleanswers)
                .HasDefaultValueSql("'1'")
                .HasColumnName("shuffleanswers");
        });

        modelBuilder.Entity<MdlQuestionHint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_hints", tb => tb.HasComment("Stores the the part of the question definition that gives di"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questionid, "mdl_queshint_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Clearwrong).HasColumnName("clearwrong");
            entity.Property(e => e.Hint).HasColumnName("hint");
            entity.Property(e => e.Hintformat).HasColumnName("hintformat");
            entity.Property(e => e.Options)
                .HasMaxLength(255)
                .HasColumnName("options");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect).HasColumnName("shownumcorrect");
        });

        modelBuilder.Entity<MdlQuestionMultianswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_multianswer", tb => tb.HasComment("Options for multianswer questions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Question, "mdl_quesmult_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
        });

        modelBuilder.Entity<MdlQuestionNumerical>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_numerical", tb => tb.HasComment("Options for numerical questions."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Answer, "mdl_quesnume_ans_ix");

            entity.HasIndex(e => e.Question, "mdl_quesnume_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Tolerance)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0.0'")
                .HasColumnName("tolerance");
        });

        modelBuilder.Entity<MdlQuestionNumericalOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_numerical_options", tb => tb.HasComment("Options for questions of type numerical This table is also u"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Question, "mdl_quesnumeopti_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Showunits).HasColumnName("showunits");
            entity.Property(e => e.Unitgradingtype).HasColumnName("unitgradingtype");
            entity.Property(e => e.Unitpenalty)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'0.1000000'")
                .HasColumnName("unitpenalty");
            entity.Property(e => e.Unitsleft).HasColumnName("unitsleft");
        });

        modelBuilder.Entity<MdlQuestionNumericalUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_numerical_units", tb => tb.HasComment("Optional unit options for numerical questions. This table is"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Question, "mdl_quesnumeunit_que_ix");

            entity.HasIndex(e => new { e.Question, e.Unit }, "mdl_quesnumeunit_queuni_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Multiplier)
                .HasPrecision(38, 19)
                .HasDefaultValueSql("'1.0000000000000000000'")
                .HasColumnName("multiplier");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("unit");
        });

        modelBuilder.Entity<MdlQuestionResponseAnalysis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_response_analysis", tb => tb.HasComment("Analysis of student responses given to questions."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aid)
                .HasMaxLength(100)
                .HasColumnName("aid");
            entity.Property(e => e.Credit)
                .HasPrecision(15, 5)
                .HasColumnName("credit");
            entity.Property(e => e.Hashcode)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("hashcode");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.Subqid)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("subqid");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Variant).HasColumnName("variant");
            entity.Property(e => e.Whichtries)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("whichtries");
        });

        modelBuilder.Entity<MdlQuestionResponseCount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_response_count", tb => tb.HasComment("Count for each responses for each try at a question."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Analysisid, "mdl_quesrespcoun_ana_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Analysisid).HasColumnName("analysisid");
            entity.Property(e => e.Rcount).HasColumnName("rcount");
            entity.Property(e => e.Try).HasColumnName("try");
        });

        modelBuilder.Entity<MdlQuestionStatistic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_statistics", tb => tb.HasComment("Statistics for individual questions used in an activity."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Discriminationindex)
                .HasPrecision(15, 5)
                .HasColumnName("discriminationindex");
            entity.Property(e => e.Discriminativeefficiency)
                .HasPrecision(15, 5)
                .HasColumnName("discriminativeefficiency");
            entity.Property(e => e.Effectiveweight)
                .HasPrecision(15, 5)
                .HasColumnName("effectiveweight");
            entity.Property(e => e.Facility)
                .HasPrecision(15, 10)
                .HasColumnName("facility");
            entity.Property(e => e.Hashcode)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("hashcode");
            entity.Property(e => e.Maxmark)
                .HasPrecision(12, 7)
                .HasColumnName("maxmark");
            entity.Property(e => e.Negcovar).HasColumnName("negcovar");
            entity.Property(e => e.Positions).HasColumnName("positions");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Randomguessscore)
                .HasPrecision(12, 7)
                .HasColumnName("randomguessscore");
            entity.Property(e => e.S).HasColumnName("s");
            entity.Property(e => e.Sd)
                .HasPrecision(15, 10)
                .HasColumnName("sd");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.Subquestion).HasColumnName("subquestion");
            entity.Property(e => e.Subquestions).HasColumnName("subquestions");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Variant).HasColumnName("variant");
        });

        modelBuilder.Entity<MdlQuestionTruefalse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_truefalse", tb => tb.HasComment("Options for True-False questions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Question, "mdl_questrue_que_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Falseanswer).HasColumnName("falseanswer");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Trueanswer).HasColumnName("trueanswer");
        });

        modelBuilder.Entity<MdlQuestionUsage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_question_usages", tb => tb.HasComment("This table's main purpose it to assign a unique id to each a"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_quesusag_con_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Preferredbehaviour)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("preferredbehaviour");
        });

        modelBuilder.Entity<MdlQuiz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quiz", tb => tb.HasComment("The settings for each quiz."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_quiz_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allowofflineattempts)
                .HasDefaultValueSql("'0'")
                .HasColumnName("allowofflineattempts");
            entity.Property(e => e.Attemptonlast).HasColumnName("attemptonlast");
            entity.Property(e => e.Attempts)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("attempts");
            entity.Property(e => e.Browsersecurity)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("browsersecurity");
            entity.Property(e => e.Canredoquestions).HasColumnName("canredoquestions");
            entity.Property(e => e.Completionattemptsexhausted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("completionattemptsexhausted");
            entity.Property(e => e.Completionminattempts).HasColumnName("completionminattempts");
            entity.Property(e => e.Completionpass)
                .HasDefaultValueSql("'0'")
                .HasColumnName("completionpass");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Decimalpoints)
                .HasDefaultValueSql("'2'")
                .HasColumnName("decimalpoints");
            entity.Property(e => e.Delay1).HasColumnName("delay1");
            entity.Property(e => e.Delay2).HasColumnName("delay2");
            entity.Property(e => e.Graceperiod).HasColumnName("graceperiod");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Grademethod)
                .HasDefaultValueSql("'1'")
                .HasColumnName("grademethod");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Navmethod)
                .HasMaxLength(16)
                .HasDefaultValueSql("'free'")
                .HasColumnName("navmethod");
            entity.Property(e => e.Overduehandling)
                .HasMaxLength(16)
                .HasDefaultValueSql("'autoabandon'")
                .HasColumnName("overduehandling");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("password");
            entity.Property(e => e.Preferredbehaviour)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("preferredbehaviour");
            entity.Property(e => e.Questiondecimalpoints)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("questiondecimalpoints");
            entity.Property(e => e.Questionsperpage).HasColumnName("questionsperpage");
            entity.Property(e => e.Reviewattempt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("reviewattempt");
            entity.Property(e => e.Reviewcorrectness)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("reviewcorrectness");
            entity.Property(e => e.Reviewgeneralfeedback)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("reviewgeneralfeedback");
            entity.Property(e => e.Reviewmarks)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("reviewmarks");
            entity.Property(e => e.Reviewoverallfeedback)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("reviewoverallfeedback");
            entity.Property(e => e.Reviewrightanswer)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("reviewrightanswer");
            entity.Property(e => e.Reviewspecificfeedback)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("reviewspecificfeedback");
            entity.Property(e => e.Showblocks).HasColumnName("showblocks");
            entity.Property(e => e.Showuserpicture).HasColumnName("showuserpicture");
            entity.Property(e => e.Shuffleanswers).HasColumnName("shuffleanswers");
            entity.Property(e => e.Subnet)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("subnet");
            entity.Property(e => e.Sumgrades)
                .HasPrecision(10, 5)
                .HasColumnName("sumgrades");
            entity.Property(e => e.Timeclose).HasColumnName("timeclose");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timelimit).HasColumnName("timelimit");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timeopen).HasColumnName("timeopen");
        });

        modelBuilder.Entity<MdlQuizAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quiz_attempts", tb => tb.HasComment("Stores users attempts at quizzes."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Quiz, "mdl_quizatte_qui_ix");

            entity.HasIndex(e => new { e.Quiz, e.Userid, e.Attempt }, "mdl_quizatte_quiuseatt_uix").IsUnique();

            entity.HasIndex(e => new { e.State, e.Timecheckstate }, "mdl_quizatte_statim_ix");

            entity.HasIndex(e => e.Uniqueid, "mdl_quizatte_uni_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_quizatte_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attempt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("attempt");
            entity.Property(e => e.Currentpage).HasColumnName("currentpage");
            entity.Property(e => e.Layout).HasColumnName("layout");
            entity.Property(e => e.Preview).HasColumnName("preview");
            entity.Property(e => e.Quiz).HasColumnName("quiz");
            entity.Property(e => e.State)
                .HasMaxLength(16)
                .HasDefaultValueSql("'inprogress'")
                .HasColumnName("state");
            entity.Property(e => e.Sumgrades)
                .HasPrecision(10, 5)
                .HasColumnName("sumgrades");
            entity.Property(e => e.Timecheckstate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("timecheckstate");
            entity.Property(e => e.Timefinish).HasColumnName("timefinish");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timemodifiedoffline).HasColumnName("timemodifiedoffline");
            entity.Property(e => e.Timestart).HasColumnName("timestart");
            entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlQuizFeedback>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quiz_feedback", tb => tb.HasComment("Feedback given to students based on which grade band their o"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Quizid, "mdl_quizfeed_qui_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Feedbacktext).HasColumnName("feedbacktext");
            entity.Property(e => e.Feedbacktextformat).HasColumnName("feedbacktextformat");
            entity.Property(e => e.Maxgrade)
                .HasPrecision(10, 5)
                .HasColumnName("maxgrade");
            entity.Property(e => e.Mingrade)
                .HasPrecision(10, 5)
                .HasColumnName("mingrade");
            entity.Property(e => e.Quizid).HasColumnName("quizid");
        });

        modelBuilder.Entity<MdlQuizGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quiz_grades", tb => tb.HasComment("Stores the overall grade for each user on the quiz, based on"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Quiz, "mdl_quizgrad_qui_ix");

            entity.HasIndex(e => e.Userid, "mdl_quizgrad_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Quiz).HasColumnName("quiz");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlQuizOverride>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quiz_overrides", tb => tb.HasComment("The overrides to quiz settings on a per-user and per-group b"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Groupid, "mdl_quizover_gro_ix");

            entity.HasIndex(e => e.Quiz, "mdl_quizover_qui_ix");

            entity.HasIndex(e => e.Userid, "mdl_quizover_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attempts)
                .HasColumnType("mediumint")
                .HasColumnName("attempts");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Quiz).HasColumnName("quiz");
            entity.Property(e => e.Timeclose).HasColumnName("timeclose");
            entity.Property(e => e.Timelimit).HasColumnName("timelimit");
            entity.Property(e => e.Timeopen).HasColumnName("timeopen");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlQuizOverviewRegrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quiz_overview_regrades", tb => tb.HasComment("This table records which question attempts need regrading an"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Questionusageid, e.Slot }, "mdl_quizoverregr_queslo_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Newfraction)
                .HasPrecision(12, 7)
                .HasColumnName("newfraction");
            entity.Property(e => e.Oldfraction)
                .HasPrecision(12, 7)
                .HasColumnName("oldfraction");
            entity.Property(e => e.Questionusageid).HasColumnName("questionusageid");
            entity.Property(e => e.Regraded).HasColumnName("regraded");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlQuizReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quiz_reports", tb => tb.HasComment("Lists all the installed quiz reports and their display order"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "mdl_quizrepo_nam_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capability)
                .HasMaxLength(255)
                .HasColumnName("capability");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<MdlQuizSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quiz_sections", tb => tb.HasComment("Stores sections of a quiz with section name (heading), from "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Quizid, "mdl_quizsect_qui_ix");

            entity.HasIndex(e => new { e.Quizid, e.Firstslot }, "mdl_quizsect_quifir_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Firstslot).HasColumnName("firstslot");
            entity.Property(e => e.Heading)
                .HasMaxLength(1333)
                .HasColumnName("heading");
            entity.Property(e => e.Quizid).HasColumnName("quizid");
            entity.Property(e => e.Shufflequestions).HasColumnName("shufflequestions");
        });

        modelBuilder.Entity<MdlQuizSlot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quiz_slots", tb => tb.HasComment("Stores the question used in a quiz, with the order, and for "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Questioncategoryid, "mdl_quizslot_que2_ix");

            entity.HasIndex(e => e.Questionid, "mdl_quizslot_que_ix");

            entity.HasIndex(e => e.Quizid, "mdl_quizslot_qui_ix");

            entity.HasIndex(e => new { e.Quizid, e.Slot }, "mdl_quizslot_quislo_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Includingsubcategories).HasColumnName("includingsubcategories");
            entity.Property(e => e.Maxmark)
                .HasPrecision(12, 7)
                .HasColumnName("maxmark");
            entity.Property(e => e.Page).HasColumnName("page");
            entity.Property(e => e.Questioncategoryid).HasColumnName("questioncategoryid");
            entity.Property(e => e.Questionid).HasColumnName("questionid");
            entity.Property(e => e.Quizid).HasColumnName("quizid");
            entity.Property(e => e.Requireprevious).HasColumnName("requireprevious");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<MdlQuizSlotTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quiz_slot_tags", tb => tb.HasComment("Stores data about the tags that a question must have so that"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Slotid, "mdl_quizslottags_slo_ix");

            entity.HasIndex(e => e.Tagid, "mdl_quizslottags_tag_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Slotid).HasColumnName("slotid");
            entity.Property(e => e.Tagid).HasColumnName("tagid");
            entity.Property(e => e.Tagname)
                .HasMaxLength(255)
                .HasColumnName("tagname");
        });

        modelBuilder.Entity<MdlQuizStatistic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quiz_statistics", tb => tb.HasComment("table to cache results from analysis done in statistics repo"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allattemptsavg)
                .HasPrecision(15, 5)
                .HasColumnName("allattemptsavg");
            entity.Property(e => e.Allattemptscount).HasColumnName("allattemptscount");
            entity.Property(e => e.Cic)
                .HasPrecision(15, 10)
                .HasColumnName("cic");
            entity.Property(e => e.Errorratio)
                .HasPrecision(15, 10)
                .HasColumnName("errorratio");
            entity.Property(e => e.Firstattemptsavg)
                .HasPrecision(15, 5)
                .HasColumnName("firstattemptsavg");
            entity.Property(e => e.Firstattemptscount).HasColumnName("firstattemptscount");
            entity.Property(e => e.Hashcode)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("hashcode");
            entity.Property(e => e.Highestattemptsavg)
                .HasPrecision(15, 5)
                .HasColumnName("highestattemptsavg");
            entity.Property(e => e.Highestattemptscount).HasColumnName("highestattemptscount");
            entity.Property(e => e.Kurtosis)
                .HasPrecision(15, 5)
                .HasColumnName("kurtosis");
            entity.Property(e => e.Lastattemptsavg)
                .HasPrecision(15, 5)
                .HasColumnName("lastattemptsavg");
            entity.Property(e => e.Lastattemptscount).HasColumnName("lastattemptscount");
            entity.Property(e => e.Median)
                .HasPrecision(15, 5)
                .HasColumnName("median");
            entity.Property(e => e.Skewness)
                .HasPrecision(15, 10)
                .HasColumnName("skewness");
            entity.Property(e => e.Standarddeviation)
                .HasPrecision(15, 5)
                .HasColumnName("standarddeviation");
            entity.Property(e => e.Standarderror)
                .HasPrecision(15, 10)
                .HasColumnName("standarderror");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Whichattempts).HasColumnName("whichattempts");
        });

        modelBuilder.Entity<MdlQuizaccessSebQuizsetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quizaccess_seb_quizsettings", tb => tb.HasComment("Stores the quiz level Safe Exam Browser configuration."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Cmid, "mdl_quizsebquiz_cmi_uix").IsUnique();

            entity.HasIndex(e => e.Quizid, "mdl_quizsebquiz_qui_uix").IsUnique();

            entity.HasIndex(e => e.Templateid, "mdl_quizsebquiz_tem_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_quizsebquiz_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activateurlfiltering).HasColumnName("activateurlfiltering");
            entity.Property(e => e.Allowedbrowserexamkeys).HasColumnName("allowedbrowserexamkeys");
            entity.Property(e => e.Allowreloadinexam).HasColumnName("allowreloadinexam");
            entity.Property(e => e.Allowspellchecking).HasColumnName("allowspellchecking");
            entity.Property(e => e.Allowuserquitseb).HasColumnName("allowuserquitseb");
            entity.Property(e => e.Cmid).HasColumnName("cmid");
            entity.Property(e => e.Enableaudiocontrol).HasColumnName("enableaudiocontrol");
            entity.Property(e => e.Expressionsallowed).HasColumnName("expressionsallowed");
            entity.Property(e => e.Expressionsblocked).HasColumnName("expressionsblocked");
            entity.Property(e => e.Filterembeddedcontent).HasColumnName("filterembeddedcontent");
            entity.Property(e => e.Linkquitseb).HasColumnName("linkquitseb");
            entity.Property(e => e.Muteonstartup).HasColumnName("muteonstartup");
            entity.Property(e => e.Quitpassword).HasColumnName("quitpassword");
            entity.Property(e => e.Quizid).HasColumnName("quizid");
            entity.Property(e => e.Regexallowed).HasColumnName("regexallowed");
            entity.Property(e => e.Regexblocked).HasColumnName("regexblocked");
            entity.Property(e => e.Requiresafeexambrowser).HasColumnName("requiresafeexambrowser");
            entity.Property(e => e.Showkeyboardlayout).HasColumnName("showkeyboardlayout");
            entity.Property(e => e.Showreloadbutton).HasColumnName("showreloadbutton");
            entity.Property(e => e.Showsebdownloadlink).HasColumnName("showsebdownloadlink");
            entity.Property(e => e.Showsebtaskbar).HasColumnName("showsebtaskbar");
            entity.Property(e => e.Showtime).HasColumnName("showtime");
            entity.Property(e => e.Showwificontrol).HasColumnName("showwificontrol");
            entity.Property(e => e.Templateid).HasColumnName("templateid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userconfirmquit).HasColumnName("userconfirmquit");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlQuizaccessSebTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_quizaccess_seb_template", tb => tb.HasComment("Templates for Safe Exam Browser configuration."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Usermodified, "mdl_quizsebtemp_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlRating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_rating", tb => tb.HasComment("moodle ratings"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Component, e.Ratingarea, e.Contextid, e.Itemid }, "mdl_rati_comratconite_ix");

            entity.HasIndex(e => e.Contextid, "mdl_rati_con_ix");

            entity.HasIndex(e => e.Userid, "mdl_rati_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.Ratingarea)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("ratingarea");
            entity.Property(e => e.Scaleid).HasColumnName("scaleid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlRegistrationHub>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_registration_hubs", tb => tb.HasComment("hub where the site is registered on with their associated to"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Confirmed).HasColumnName("confirmed");
            entity.Property(e => e.Hubname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("hubname");
            entity.Property(e => e.Huburl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("huburl");
            entity.Property(e => e.Secret)
                .HasMaxLength(255)
                .HasColumnName("secret");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("token");
        });

        modelBuilder.Entity<MdlRepository>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_repository", tb => tb.HasComment("This table contains one entry for every configured external "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlRepositoryInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_repository_instances", tb => tb.HasComment("This table contains one entry for every configured external "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Readonly).HasColumnName("readonly");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Typeid).HasColumnName("typeid");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<MdlRepositoryInstanceConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_repository_instance_config", tb => tb.HasComment("The config for intances"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Instanceid).HasColumnName("instanceid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlRepositoryOnedriveAccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_repository_onedrive_access", tb => tb.HasComment("List of temporary access grants."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Usermodified, "mdl_repoonedacce_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Itemid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("itemid");
            entity.Property(e => e.Permissionid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("permissionid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_resource", tb => tb.HasComment("Each record is one resource and its config data"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_reso_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Display).HasColumnName("display");
            entity.Property(e => e.Displayoptions).HasColumnName("displayoptions");
            entity.Property(e => e.Filterfiles).HasColumnName("filterfiles");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Legacyfiles).HasColumnName("legacyfiles");
            entity.Property(e => e.Legacyfileslast).HasColumnName("legacyfileslast");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Revision).HasColumnName("revision");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Tobemigrated).HasColumnName("tobemigrated");
        });

        modelBuilder.Entity<MdlResourceOld>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_resource_old", tb => tb.HasComment("backup of all old resource instances from 1.9"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Cmid, "mdl_resoold_cmi_ix");

            entity.HasIndex(e => e.Oldid, "mdl_resoold_old_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alltext).HasColumnName("alltext");
            entity.Property(e => e.Cmid).HasColumnName("cmid");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Migrated).HasColumnName("migrated");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Newid).HasColumnName("newid");
            entity.Property(e => e.Newmodule)
                .HasMaxLength(50)
                .HasColumnName("newmodule");
            entity.Property(e => e.Oldid).HasColumnName("oldid");
            entity.Property(e => e.Options)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("options");
            entity.Property(e => e.Popup).HasColumnName("popup");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("reference");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
        });

        modelBuilder.Entity<MdlRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_role", tb => tb.HasComment("moodle roles"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Shortname, "mdl_role_sho_uix").IsUnique();

            entity.HasIndex(e => e.Sortorder, "mdl_role_sor_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Archetype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("archetype");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlRoleAllowAssign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_role_allow_assign", tb => tb.HasComment("this defines what role can assign what role"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Allowassign, "mdl_rolealloassi_all_ix");

            entity.HasIndex(e => e.Roleid, "mdl_rolealloassi_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Allowassign }, "mdl_rolealloassi_rolall_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allowassign).HasColumnName("allowassign");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
        });

        modelBuilder.Entity<MdlRoleAllowOverride>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_role_allow_override", tb => tb.HasComment("this defines what role can override what role"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Allowoverride, "mdl_rolealloover_all_ix");

            entity.HasIndex(e => e.Roleid, "mdl_rolealloover_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Allowoverride }, "mdl_rolealloover_rolall_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allowoverride).HasColumnName("allowoverride");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
        });

        modelBuilder.Entity<MdlRoleAllowSwitch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_role_allow_switch", tb => tb.HasComment("This table stores which which other roles a user is allowed "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Allowswitch, "mdl_rolealloswit_all_ix");

            entity.HasIndex(e => e.Roleid, "mdl_rolealloswit_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Allowswitch }, "mdl_rolealloswit_rolall_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allowswitch).HasColumnName("allowswitch");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
        });

        modelBuilder.Entity<MdlRoleAllowView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_role_allow_view", tb => tb.HasComment("This table stores which which other roles a user is allowed "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Allowview, "mdl_rolealloview_all_ix");

            entity.HasIndex(e => e.Roleid, "mdl_rolealloview_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Allowview }, "mdl_rolealloview_rolall_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allowview).HasColumnName("allowview");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
        });

        modelBuilder.Entity<MdlRoleAssignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_role_assignments", tb => tb.HasComment("assigning roles in different context"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Component, e.Itemid, e.Userid }, "mdl_roleassi_comiteuse_ix");

            entity.HasIndex(e => e.Contextid, "mdl_roleassi_con_ix");

            entity.HasIndex(e => e.Roleid, "mdl_roleassi_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Contextid }, "mdl_roleassi_rolcon_ix");

            entity.HasIndex(e => e.Sortorder, "mdl_roleassi_sor_ix");

            entity.HasIndex(e => e.Userid, "mdl_roleassi_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Contextid, e.Roleid }, "mdl_roleassi_useconrol_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Modifierid).HasColumnName("modifierid");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlRoleCapability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_role_capabilities", tb => tb.HasComment("permission has to be signed, overriding a capability for a p"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Capability, "mdl_rolecapa_cap_ix");

            entity.HasIndex(e => e.Contextid, "mdl_rolecapa_con_ix");

            entity.HasIndex(e => e.Modifierid, "mdl_rolecapa_mod_ix");

            entity.HasIndex(e => e.Roleid, "mdl_rolecapa_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Contextid, e.Capability }, "mdl_rolecapa_rolconcap_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capability)
                .HasDefaultValueSql("''")
                .HasColumnName("capability");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Modifierid).HasColumnName("modifierid");
            entity.Property(e => e.Permission).HasColumnName("permission");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlRoleContextLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_role_context_levels", tb => tb.HasComment("Lists which roles can be assigned at which context levels. T"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Contextlevel, e.Roleid }, "mdl_rolecontleve_conrol_uix").IsUnique();

            entity.HasIndex(e => e.Roleid, "mdl_rolecontleve_rol_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextlevel).HasColumnName("contextlevel");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
        });

        modelBuilder.Entity<MdlRoleName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_role_names", tb => tb.HasComment("role names in native strings"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_rolename_con_ix");

            entity.HasIndex(e => e.Roleid, "mdl_rolename_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Contextid }, "mdl_rolename_rolcon_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
        });

        modelBuilder.Entity<MdlScale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scale", tb => tb.HasComment("Defines grading scales"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_scal_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Scale).HasColumnName("scale");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlScaleHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scale_history", tb => tb.HasComment("History table"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Action, "mdl_scalhist_act_ix");

            entity.HasIndex(e => e.Courseid, "mdl_scalhist_cou_ix");

            entity.HasIndex(e => e.Loggeduser, "mdl_scalhist_log_ix");

            entity.HasIndex(e => e.Oldid, "mdl_scalhist_old_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_scalhist_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Loggeduser).HasColumnName("loggeduser");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Oldid).HasColumnName("oldid");
            entity.Property(e => e.Scale).HasColumnName("scale");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlScorm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scorm", tb => tb.HasComment("each table is one SCORM module and its configuration"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_scor_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Auto).HasColumnName("auto");
            entity.Property(e => e.Autocommit).HasColumnName("autocommit");
            entity.Property(e => e.Completionscorerequired).HasColumnName("completionscorerequired");
            entity.Property(e => e.Completionstatusallscos).HasColumnName("completionstatusallscos");
            entity.Property(e => e.Completionstatusrequired).HasColumnName("completionstatusrequired");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Displayactivityname)
                .HasDefaultValueSql("'1'")
                .HasColumnName("displayactivityname");
            entity.Property(e => e.Displayattemptstatus)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("displayattemptstatus");
            entity.Property(e => e.Displaycoursestructure).HasColumnName("displaycoursestructure");
            entity.Property(e => e.Forcecompleted).HasColumnName("forcecompleted");
            entity.Property(e => e.Forcenewattempt).HasColumnName("forcenewattempt");
            entity.Property(e => e.Grademethod).HasColumnName("grademethod");
            entity.Property(e => e.Height)
                .HasDefaultValueSql("'600'")
                .HasColumnName("height");
            entity.Property(e => e.Hidebrowse).HasColumnName("hidebrowse");
            entity.Property(e => e.Hidetoc).HasColumnName("hidetoc");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Lastattemptlock).HasColumnName("lastattemptlock");
            entity.Property(e => e.Launch).HasColumnName("launch");
            entity.Property(e => e.Masteryoverride)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("masteryoverride");
            entity.Property(e => e.Maxattempt)
                .HasDefaultValueSql("'1'")
                .HasColumnName("maxattempt");
            entity.Property(e => e.Maxgrade).HasColumnName("maxgrade");
            entity.Property(e => e.Md5hash)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("md5hash");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Nav)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("nav");
            entity.Property(e => e.Navpositionleft)
                .HasDefaultValueSql("'-100'")
                .HasColumnName("navpositionleft");
            entity.Property(e => e.Navpositiontop)
                .HasDefaultValueSql("'-100'")
                .HasColumnName("navpositiontop");
            entity.Property(e => e.Options)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("options");
            entity.Property(e => e.Popup).HasColumnName("popup");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("reference");
            entity.Property(e => e.Revision).HasColumnName("revision");
            entity.Property(e => e.Scormtype)
                .HasMaxLength(50)
                .HasDefaultValueSql("'local'")
                .HasColumnName("scormtype");
            entity.Property(e => e.Sha1hash)
                .HasMaxLength(40)
                .HasColumnName("sha1hash");
            entity.Property(e => e.Skipview)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("skipview");
            entity.Property(e => e.Timeclose).HasColumnName("timeclose");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timeopen).HasColumnName("timeopen");
            entity.Property(e => e.Updatefreq).HasColumnName("updatefreq");
            entity.Property(e => e.Version)
                .HasMaxLength(9)
                .HasDefaultValueSql("''")
                .HasColumnName("version");
            entity.Property(e => e.Whatgrade).HasColumnName("whatgrade");
            entity.Property(e => e.Width)
                .HasDefaultValueSql("'100'")
                .HasColumnName("width");
        });

        modelBuilder.Entity<MdlScormAiccSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scorm_aicc_session", tb => tb.HasComment("Used by AICC HACP to store session information"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Scormid, "mdl_scoraiccsess_sco_ix");

            entity.HasIndex(e => e.Userid, "mdl_scoraiccsess_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attempt).HasColumnName("attempt");
            entity.Property(e => e.Hacpsession)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("hacpsession");
            entity.Property(e => e.Lessonstatus)
                .HasMaxLength(255)
                .HasColumnName("lessonstatus");
            entity.Property(e => e.Scoid)
                .HasDefaultValueSql("'0'")
                .HasColumnName("scoid");
            entity.Property(e => e.Scormid).HasColumnName("scormid");
            entity.Property(e => e.Scormmode)
                .HasMaxLength(50)
                .HasColumnName("scormmode");
            entity.Property(e => e.Scormstatus)
                .HasMaxLength(255)
                .HasColumnName("scormstatus");
            entity.Property(e => e.Sessiontime)
                .HasMaxLength(255)
                .HasColumnName("sessiontime");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlScormSco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scorm_scoes", tb => tb.HasComment("each SCO part of the SCORM module"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Scorm, "mdl_scorscoe_sco_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Identifier)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("identifier");
            entity.Property(e => e.Launch).HasColumnName("launch");
            entity.Property(e => e.Manifest)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("manifest");
            entity.Property(e => e.Organization)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("organization");
            entity.Property(e => e.Parent)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("parent");
            entity.Property(e => e.Scorm).HasColumnName("scorm");
            entity.Property(e => e.Scormtype)
                .HasMaxLength(5)
                .HasDefaultValueSql("''")
                .HasColumnName("scormtype");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        modelBuilder.Entity<MdlScormScoesDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scorm_scoes_data", tb => tb.HasComment("Contains variable data get from packages"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Scoid, "mdl_scorscoedata_sco_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Scoid).HasColumnName("scoid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlScormScoesTrack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scorm_scoes_track", tb => tb.HasComment("to track SCOes"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Scoid, "mdl_scorscoetrac_sco2_ix");

            entity.HasIndex(e => e.Scormid, "mdl_scorscoetrac_sco_ix");

            entity.HasIndex(e => e.Userid, "mdl_scorscoetrac_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Scormid, e.Scoid, e.Attempt, e.Element }, "mdl_scorscoetrac_usescosco_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attempt)
                .HasDefaultValueSql("'1'")
                .HasColumnName("attempt");
            entity.Property(e => e.Element)
                .HasDefaultValueSql("''")
                .HasColumnName("element");
            entity.Property(e => e.Scoid).HasColumnName("scoid");
            entity.Property(e => e.Scormid).HasColumnName("scormid");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlScormSeqMapinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scorm_seq_mapinfo", tb => tb.HasComment("SCORM2004 objective mapinfo description"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Objectiveid, "mdl_scorseqmapi_obj_ix");

            entity.HasIndex(e => e.Scoid, "mdl_scorseqmapi_sco_ix");

            entity.HasIndex(e => new { e.Scoid, e.Id, e.Objectiveid }, "mdl_scorseqmapi_scoidobj_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Objectiveid).HasColumnName("objectiveid");
            entity.Property(e => e.Readnormalizedmeasure)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("readnormalizedmeasure");
            entity.Property(e => e.Readsatisfiedstatus)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("readsatisfiedstatus");
            entity.Property(e => e.Scoid).HasColumnName("scoid");
            entity.Property(e => e.Targetobjectiveid).HasColumnName("targetobjectiveid");
            entity.Property(e => e.Writenormalizedmeasure).HasColumnName("writenormalizedmeasure");
            entity.Property(e => e.Writesatisfiedstatus).HasColumnName("writesatisfiedstatus");
        });

        modelBuilder.Entity<MdlScormSeqObjective>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scorm_seq_objective", tb => tb.HasComment("SCORM2004 objective description"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Scoid, "mdl_scorseqobje_sco_ix");

            entity.HasIndex(e => new { e.Scoid, e.Id }, "mdl_scorseqobje_scoid_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Minnormalizedmeasure)
                .HasColumnType("float(11,4)")
                .HasColumnName("minnormalizedmeasure");
            entity.Property(e => e.Objectiveid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("objectiveid");
            entity.Property(e => e.Primaryobj).HasColumnName("primaryobj");
            entity.Property(e => e.Satisfiedbymeasure)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("satisfiedbymeasure");
            entity.Property(e => e.Scoid).HasColumnName("scoid");
        });

        modelBuilder.Entity<MdlScormSeqRolluprule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scorm_seq_rolluprule", tb => tb.HasComment("SCORM2004 sequencing rule"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Scoid, "mdl_scorseqroll_sco_ix");

            entity.HasIndex(e => new { e.Scoid, e.Id }, "mdl_scorseqroll_scoid_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Childactivityset)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("childactivityset");
            entity.Property(e => e.Conditioncombination)
                .HasMaxLength(3)
                .HasDefaultValueSql("'all'")
                .HasColumnName("conditioncombination");
            entity.Property(e => e.Minimumcount).HasColumnName("minimumcount");
            entity.Property(e => e.Minimumpercent)
                .HasColumnType("float(11,4)")
                .HasColumnName("minimumpercent");
            entity.Property(e => e.Scoid).HasColumnName("scoid");
        });

        modelBuilder.Entity<MdlScormSeqRolluprulecond>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scorm_seq_rolluprulecond", tb => tb.HasComment("SCORM2004 sequencing rule"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Rollupruleid, "mdl_scorseqroll_rol_ix");

            entity.HasIndex(e => e.Scoid, "mdl_scorseqroll_sco2_ix");

            entity.HasIndex(e => new { e.Scoid, e.Rollupruleid, e.Id }, "mdl_scorseqroll_scorolid_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cond)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("cond");
            entity.Property(e => e.Operator)
                .HasMaxLength(5)
                .HasDefaultValueSql("'noOp'")
                .HasColumnName("operator");
            entity.Property(e => e.Rollupruleid).HasColumnName("rollupruleid");
            entity.Property(e => e.Scoid).HasColumnName("scoid");
        });

        modelBuilder.Entity<MdlScormSeqRulecond>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scorm_seq_rulecond", tb => tb.HasComment("SCORM2004 rule condition"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Id, e.Scoid, e.Ruleconditionsid }, "mdl_scorseqrule_idscorul_uix").IsUnique();

            entity.HasIndex(e => e.Ruleconditionsid, "mdl_scorseqrule_rul_ix");

            entity.HasIndex(e => e.Scoid, "mdl_scorseqrule_sco2_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cond)
                .HasMaxLength(30)
                .HasDefaultValueSql("'always'")
                .HasColumnName("cond");
            entity.Property(e => e.Measurethreshold)
                .HasColumnType("float(11,4)")
                .HasColumnName("measurethreshold");
            entity.Property(e => e.Operator)
                .HasMaxLength(5)
                .HasDefaultValueSql("'noOp'")
                .HasColumnName("operator");
            entity.Property(e => e.Refrencedobjective)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("refrencedobjective");
            entity.Property(e => e.Ruleconditionsid).HasColumnName("ruleconditionsid");
            entity.Property(e => e.Scoid).HasColumnName("scoid");
        });

        modelBuilder.Entity<MdlScormSeqRulecond1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_scorm_seq_ruleconds", tb => tb.HasComment("SCORM2004 rule conditions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Scoid, "mdl_scorseqrule_sco_ix");

            entity.HasIndex(e => new { e.Scoid, e.Id }, "mdl_scorseqrule_scoid_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Conditioncombination)
                .HasMaxLength(3)
                .HasDefaultValueSql("'all'")
                .HasColumnName("conditioncombination");
            entity.Property(e => e.Ruletype).HasColumnName("ruletype");
            entity.Property(e => e.Scoid).HasColumnName("scoid");
        });

        modelBuilder.Entity<MdlSearchIndexRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_search_index_requests", tb => tb.HasComment("Records requests for (re)indexing of specific contexts. Entr"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_searinderequ_con_ix");

            entity.HasIndex(e => new { e.Indexpriority, e.Timerequested }, "mdl_searinderequ_indtim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Indexpriority).HasColumnName("indexpriority");
            entity.Property(e => e.Partialarea)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("partialarea");
            entity.Property(e => e.Partialtime).HasColumnName("partialtime");
            entity.Property(e => e.Searcharea)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("searcharea");
            entity.Property(e => e.Timerequested).HasColumnName("timerequested");
        });

        modelBuilder.Entity<MdlSearchSimpledbIndex>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_search_simpledb_index", tb => tb.HasComment("search_simpledb table containing the index data."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Title, e.Content, e.Description1, e.Description2 }, "mdl_search_simpledb_index_index").HasAnnotation("MySql:FullTextIndex", true);

            entity.HasIndex(e => e.Docid, "mdl_searsimpinde_doc_uix").IsUnique();

            entity.HasIndex(e => new { e.Owneruserid, e.Contextid }, "mdl_searsimpinde_owncon_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Areaid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("areaid");
            entity.Property(e => e.Content)
                .HasColumnType("longtext")
                .HasColumnName("content");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Description1)
                .HasColumnType("longtext")
                .HasColumnName("description1");
            entity.Property(e => e.Description2)
                .HasColumnType("longtext")
                .HasColumnName("description2");
            entity.Property(e => e.Docid)
                .HasDefaultValueSql("''")
                .HasColumnName("docid");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Modified).HasColumnName("modified");
            entity.Property(e => e.Owneruserid).HasColumnName("owneruserid");
            entity.Property(e => e.Title)
                .HasColumnType("longtext")
                .HasColumnName("title");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_sessions", tb => tb.HasComment("Database based session storage - now recommended"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Sid, "mdl_sess_sid_uix").IsUnique();

            entity.HasIndex(e => e.State, "mdl_sess_sta_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_sess_tim2_ix");

            entity.HasIndex(e => e.Timecreated, "mdl_sess_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_sess_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Firstip)
                .HasMaxLength(45)
                .HasColumnName("firstip");
            entity.Property(e => e.Lastip)
                .HasMaxLength(45)
                .HasColumnName("lastip");
            entity.Property(e => e.Sessdata).HasColumnName("sessdata");
            entity.Property(e => e.Sid)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("sid");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlStatsDaily>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_stats_daily", tb => tb.HasComment("to accumulate daily stats"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_statdail_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_statdail_rol_ix");

            entity.HasIndex(e => e.Timeend, "mdl_statdail_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Stat1).HasColumnName("stat1");
            entity.Property(e => e.Stat2).HasColumnName("stat2");
            entity.Property(e => e.Stattype)
                .HasMaxLength(20)
                .HasDefaultValueSql("'activity'")
                .HasColumnName("stattype");
            entity.Property(e => e.Timeend).HasColumnName("timeend");
        });

        modelBuilder.Entity<MdlStatsMonthly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_stats_monthly", tb => tb.HasComment("To accumulate monthly stats"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_statmont_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_statmont_rol_ix");

            entity.HasIndex(e => e.Timeend, "mdl_statmont_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Stat1).HasColumnName("stat1");
            entity.Property(e => e.Stat2).HasColumnName("stat2");
            entity.Property(e => e.Stattype)
                .HasMaxLength(20)
                .HasDefaultValueSql("'activity'")
                .HasColumnName("stattype");
            entity.Property(e => e.Timeend).HasColumnName("timeend");
        });

        modelBuilder.Entity<MdlStatsUserDaily>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_stats_user_daily", tb => tb.HasComment("To accumulate daily stats per course/user"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_statuserdail_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_statuserdail_rol_ix");

            entity.HasIndex(e => e.Timeend, "mdl_statuserdail_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_statuserdail_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Statsreads).HasColumnName("statsreads");
            entity.Property(e => e.Statswrites).HasColumnName("statswrites");
            entity.Property(e => e.Stattype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("stattype");
            entity.Property(e => e.Timeend).HasColumnName("timeend");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlStatsUserMonthly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_stats_user_monthly", tb => tb.HasComment("To accumulate monthly stats per course/user"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_statusermont_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_statusermont_rol_ix");

            entity.HasIndex(e => e.Timeend, "mdl_statusermont_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_statusermont_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Statsreads).HasColumnName("statsreads");
            entity.Property(e => e.Statswrites).HasColumnName("statswrites");
            entity.Property(e => e.Stattype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("stattype");
            entity.Property(e => e.Timeend).HasColumnName("timeend");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlStatsUserWeekly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_stats_user_weekly", tb => tb.HasComment("To accumulate weekly stats per course/user"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_statuserweek_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_statuserweek_rol_ix");

            entity.HasIndex(e => e.Timeend, "mdl_statuserweek_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_statuserweek_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Statsreads).HasColumnName("statsreads");
            entity.Property(e => e.Statswrites).HasColumnName("statswrites");
            entity.Property(e => e.Stattype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("stattype");
            entity.Property(e => e.Timeend).HasColumnName("timeend");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlStatsWeekly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_stats_weekly", tb => tb.HasComment("To accumulate weekly stats"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_statweek_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_statweek_rol_ix");

            entity.HasIndex(e => e.Timeend, "mdl_statweek_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Stat1).HasColumnName("stat1");
            entity.Property(e => e.Stat2).HasColumnName("stat2");
            entity.Property(e => e.Stattype)
                .HasMaxLength(20)
                .HasDefaultValueSql("'activity'")
                .HasColumnName("stattype");
            entity.Property(e => e.Timeend).HasColumnName("timeend");
        });

        modelBuilder.Entity<MdlSurvey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_survey", tb => tb.HasComment("Each record is one SURVEY module with its configuration"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_surv_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Completionsubmit).HasColumnName("completionsubmit");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Days)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("days");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Questions)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("questions");
            entity.Property(e => e.Template).HasColumnName("template");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlSurveyAnalysis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_survey_analysis", tb => tb.HasComment("text about each survey submission"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Survey, "mdl_survanal_sur_ix");

            entity.HasIndex(e => e.Userid, "mdl_survanal_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Survey).HasColumnName("survey");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlSurveyAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_survey_answers", tb => tb.HasComment("the answers to each questions filled by the users"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Question, "mdl_survansw_que_ix");

            entity.HasIndex(e => e.Survey, "mdl_survansw_sur_ix");

            entity.HasIndex(e => e.Userid, "mdl_survansw_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answer1).HasColumnName("answer1");
            entity.Property(e => e.Answer2).HasColumnName("answer2");
            entity.Property(e => e.Question).HasColumnName("question");
            entity.Property(e => e.Survey).HasColumnName("survey");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlSurveyQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_survey_questions", tb => tb.HasComment("the questions conforming one survey"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Intro)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("intro");
            entity.Property(e => e.Multi)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("multi");
            entity.Property(e => e.Options).HasColumnName("options");
            entity.Property(e => e.Shorttext)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("shorttext");
            entity.Property(e => e.Text)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("text");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<MdlTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tag", tb => tb.HasComment("Tag table - this generic table will replace the old \"tags\" t"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Tagcollid, "mdl_tag_tag_ix");

            entity.HasIndex(e => new { e.Tagcollid, e.Isstandard }, "mdl_tag_tagiss_ix");

            entity.HasIndex(e => new { e.Tagcollid, e.Name }, "mdl_tag_tagnam_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_tag_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("'0'")
                .HasColumnName("flag");
            entity.Property(e => e.Isstandard).HasColumnName("isstandard");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Rawname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("rawname");
            entity.Property(e => e.Tagcollid).HasColumnName("tagcollid");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlTagArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tag_area", tb => tb.HasComment("Defines various tag areas, one area is identified by compone"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Component, e.Itemtype }, "mdl_tagarea_comite_uix").IsUnique();

            entity.HasIndex(e => e.Tagcollid, "mdl_tagarea_tag_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Callback)
                .HasMaxLength(100)
                .HasColumnName("callback");
            entity.Property(e => e.Callbackfile)
                .HasMaxLength(100)
                .HasColumnName("callbackfile");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabled");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("itemtype");
            entity.Property(e => e.Multiplecontexts).HasColumnName("multiplecontexts");
            entity.Property(e => e.Showstandard).HasColumnName("showstandard");
            entity.Property(e => e.Tagcollid).HasColumnName("tagcollid");
        });

        modelBuilder.Entity<MdlTagColl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tag_coll", tb => tb.HasComment("Defines different set of tags"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Customurl)
                .HasMaxLength(255)
                .HasColumnName("customurl");
            entity.Property(e => e.Isdefault).HasColumnName("isdefault");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Searchable)
                .HasDefaultValueSql("'1'")
                .HasColumnName("searchable");
            entity.Property(e => e.Sortorder)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlTagCorrelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tag_correlation", tb => tb.HasComment("The rationale for the 'tag_correlation' table is performance"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Tagid, "mdl_tagcorr_tag_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Correlatedtags).HasColumnName("correlatedtags");
            entity.Property(e => e.Tagid).HasColumnName("tagid");
        });

        modelBuilder.Entity<MdlTagInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tag_instance", tb => tb.HasComment("tag_instance table holds the information of associations bet"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Component, e.Itemtype, e.Itemid, e.Contextid, e.Tiuserid, e.Tagid }, "mdl_taginst_comiteiteconti_uix").IsUnique();

            entity.HasIndex(e => e.Contextid, "mdl_taginst_con_ix");

            entity.HasIndex(e => new { e.Itemtype, e.Component, e.Tagid, e.Contextid }, "mdl_taginst_itecomtagcon_ix");

            entity.HasIndex(e => e.Tagid, "mdl_taginst_tag_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("itemtype");
            entity.Property(e => e.Ordering).HasColumnName("ordering");
            entity.Property(e => e.Tagid).HasColumnName("tagid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Tiuserid).HasColumnName("tiuserid");
        });

        modelBuilder.Entity<MdlTaskAdhoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_task_adhoc", tb => tb.HasComment("List of adhoc tasks waiting to run."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Nextruntime, "mdl_taskadho_nex_ix");

            entity.HasIndex(e => e.Userid, "mdl_taskadho_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Blocking).HasColumnName("blocking");
            entity.Property(e => e.Classname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("classname");
            entity.Property(e => e.Component)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Customdata).HasColumnName("customdata");
            entity.Property(e => e.Faildelay).HasColumnName("faildelay");
            entity.Property(e => e.Hostname)
                .HasMaxLength(255)
                .HasColumnName("hostname");
            entity.Property(e => e.Nextruntime).HasColumnName("nextruntime");
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timestarted).HasColumnName("timestarted");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlTaskLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_task_log")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Classname, "mdl_tasklog_cla_ix");

            entity.HasIndex(e => e.Timestart, "mdl_tasklog_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Classname)
                .HasDefaultValueSql("''")
                .HasColumnName("classname");
            entity.Property(e => e.Component)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Dbreads).HasColumnName("dbreads");
            entity.Property(e => e.Dbwrites).HasColumnName("dbwrites");
            entity.Property(e => e.Hostname)
                .HasMaxLength(255)
                .HasColumnName("hostname");
            entity.Property(e => e.Output).HasColumnName("output");
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Result).HasColumnName("result");
            entity.Property(e => e.Timeend)
                .HasPrecision(20, 10)
                .HasColumnName("timeend");
            entity.Property(e => e.Timestart)
                .HasPrecision(20, 10)
                .HasColumnName("timestart");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlTaskScheduled>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_task_scheduled", tb => tb.HasComment("List of scheduled tasks to be run by cron."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Classname, "mdl_tasksche_cla_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Blocking).HasColumnName("blocking");
            entity.Property(e => e.Classname)
                .HasDefaultValueSql("''")
                .HasColumnName("classname");
            entity.Property(e => e.Component)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Customised).HasColumnName("customised");
            entity.Property(e => e.Day)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("day");
            entity.Property(e => e.Dayofweek)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("dayofweek");
            entity.Property(e => e.Disabled).HasColumnName("disabled");
            entity.Property(e => e.Faildelay).HasColumnName("faildelay");
            entity.Property(e => e.Hostname)
                .HasMaxLength(255)
                .HasColumnName("hostname");
            entity.Property(e => e.Hour)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("hour");
            entity.Property(e => e.Lastruntime).HasColumnName("lastruntime");
            entity.Property(e => e.Minute)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("minute");
            entity.Property(e => e.Month)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("month");
            entity.Property(e => e.Nextruntime).HasColumnName("nextruntime");
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Timestarted).HasColumnName("timestarted");
        });

        modelBuilder.Entity<MdlToolBrickfieldArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_brickfield_areas", tb => tb.HasComment("Areas that have been checked for accessibility problems"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Categoryid, "mdl_toolbricarea_cat_ix");

            entity.HasIndex(e => e.Cmid, "mdl_toolbricarea_cmi_ix");

            entity.HasIndex(e => e.Contextid, "mdl_toolbricarea_con_ix");

            entity.HasIndex(e => e.Courseid, "mdl_toolbricarea_cou_ix");

            entity.HasIndex(e => new { e.Courseid, e.Cmid }, "mdl_toolbricarea_coucmi_ix");

            entity.HasIndex(e => new { e.Reftable, e.Refid, e.Type }, "mdl_toolbricarea_refreftyp_ix");

            entity.HasIndex(e => new { e.Type, e.Contextid, e.Component, e.Fieldorarea, e.Itemid }, "mdl_toolbricarea_typconcomf_ix");

            entity.HasIndex(e => new { e.Type, e.Tablename, e.Itemid, e.Fieldorarea }, "mdl_toolbricarea_typtabitef_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Cmid).HasColumnName("cmid");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Fieldorarea)
                .HasMaxLength(50)
                .HasColumnName("fieldorarea");
            entity.Property(e => e.Filename)
                .HasMaxLength(1333)
                .HasColumnName("filename");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Refid).HasColumnName("refid");
            entity.Property(e => e.Reftable)
                .HasMaxLength(40)
                .HasColumnName("reftable");
            entity.Property(e => e.Tablename)
                .HasMaxLength(40)
                .HasColumnName("tablename");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<MdlToolBrickfieldCacheAct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_brickfield_cache_acts", tb => tb.HasComment("Contains accessibility summary information per activity."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_toolbriccachacts_cou_ix");

            entity.HasIndex(e => e.Status, "mdl_toolbriccachacts_sta_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(64)
                .HasColumnName("component");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Errorcount).HasColumnName("errorcount");
            entity.Property(e => e.Failedactivities).HasColumnName("failedactivities");
            entity.Property(e => e.Passedactivities).HasColumnName("passedactivities");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Totalactivities).HasColumnName("totalactivities");
        });

        modelBuilder.Entity<MdlToolBrickfieldCacheCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_brickfield_cache_check", tb => tb.HasComment("Contains accessibility summary information per check."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_toolbriccachchec_cou_ix");

            entity.HasIndex(e => e.Errorcount, "mdl_toolbriccachchec_err_ix");

            entity.HasIndex(e => e.Status, "mdl_toolbriccachchec_sta_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Checkcount).HasColumnName("checkcount");
            entity.Property(e => e.Checkid).HasColumnName("checkid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Errorcount).HasColumnName("errorcount");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MdlToolBrickfieldCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_brickfield_checks", tb => tb.HasComment("Checks details"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Checkgroup, "mdl_toolbricchec_che2_ix");

            entity.HasIndex(e => e.Checktype, "mdl_toolbricchec_che_ix");

            entity.HasIndex(e => e.Status, "mdl_toolbricchec_sta_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Checkgroup)
                .HasDefaultValueSql("'0'")
                .HasColumnName("checkgroup");
            entity.Property(e => e.Checktype)
                .HasMaxLength(64)
                .HasColumnName("checktype");
            entity.Property(e => e.Severity).HasColumnName("severity");
            entity.Property(e => e.Shortname)
                .HasMaxLength(64)
                .HasColumnName("shortname");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MdlToolBrickfieldContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_brickfield_content", tb => tb.HasComment("Content of an area at a particular time (recognised by a has"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Areaid, "mdl_toolbriccont_are_ix");

            entity.HasIndex(e => new { e.Iscurrent, e.Areaid }, "mdl_toolbriccont_iscare_ix");

            entity.HasIndex(e => e.Status, "mdl_toolbriccont_sta_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Areaid).HasColumnName("areaid");
            entity.Property(e => e.Contenthash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("contenthash");
            entity.Property(e => e.Iscurrent).HasColumnName("iscurrent");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timechecked).HasColumnName("timechecked");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlToolBrickfieldError>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_brickfield_errors", tb => tb.HasComment("Errors during the accessibility checks"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Resultid, "mdl_toolbricerro_res_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Errordata).HasColumnName("errordata");
            entity.Property(e => e.Htmlcode).HasColumnName("htmlcode");
            entity.Property(e => e.Linenumber).HasColumnName("linenumber");
            entity.Property(e => e.Resultid).HasColumnName("resultid");
        });

        modelBuilder.Entity<MdlToolBrickfieldProcess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_brickfield_process", tb => tb.HasComment("Queued records to initiate new processing of specific target"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Timecompleted, "mdl_toolbricproc_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Innercontextid).HasColumnName("innercontextid");
            entity.Property(e => e.Item)
                .HasMaxLength(64)
                .HasColumnName("item");
            entity.Property(e => e.Timecompleted).HasColumnName("timecompleted");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlToolBrickfieldResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_brickfield_results", tb => tb.HasComment("Results of the accessibility checks"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Checkid, "mdl_toolbricresu_che_ix");

            entity.HasIndex(e => e.Contentid, "mdl_toolbricresu_con_ix");

            entity.HasIndex(e => new { e.Contentid, e.Checkid }, "mdl_toolbricresu_conche_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Checkid).HasColumnName("checkid");
            entity.Property(e => e.Contentid).HasColumnName("contentid");
            entity.Property(e => e.Errorcount).HasColumnName("errorcount");
        });

        modelBuilder.Entity<MdlToolBrickfieldSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_brickfield_schedule", tb => tb.HasComment("Keeps the per course content analysis schedule."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Contextlevel, e.Instanceid }, "mdl_toolbricsche_conins_uix").IsUnique();

            entity.HasIndex(e => e.Status, "mdl_toolbricsche_sta_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Contextlevel)
                .HasDefaultValueSql("'50'")
                .HasColumnName("contextlevel");
            entity.Property(e => e.Instanceid).HasColumnName("instanceid");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timeanalyzed)
                .HasDefaultValueSql("'0'")
                .HasColumnName("timeanalyzed");
            entity.Property(e => e.Timemodified)
                .HasDefaultValueSql("'0'")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlToolBrickfieldSummary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_brickfield_summary", tb => tb.HasComment("Contains accessibility check results summary information."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_toolbricsumm_cou_ix");

            entity.HasIndex(e => e.Status, "mdl_toolbricsumm_sta_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activities).HasColumnName("activities");
            entity.Property(e => e.Activitiesfailed).HasColumnName("activitiesfailed");
            entity.Property(e => e.Activitiespassed).HasColumnName("activitiespassed");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Errorschecktype1).HasColumnName("errorschecktype1");
            entity.Property(e => e.Errorschecktype2).HasColumnName("errorschecktype2");
            entity.Property(e => e.Errorschecktype3).HasColumnName("errorschecktype3");
            entity.Property(e => e.Errorschecktype4).HasColumnName("errorschecktype4");
            entity.Property(e => e.Errorschecktype5).HasColumnName("errorschecktype5");
            entity.Property(e => e.Errorschecktype6).HasColumnName("errorschecktype6");
            entity.Property(e => e.Errorschecktype7).HasColumnName("errorschecktype7");
            entity.Property(e => e.Failedchecktype1).HasColumnName("failedchecktype1");
            entity.Property(e => e.Failedchecktype2).HasColumnName("failedchecktype2");
            entity.Property(e => e.Failedchecktype3).HasColumnName("failedchecktype3");
            entity.Property(e => e.Failedchecktype4).HasColumnName("failedchecktype4");
            entity.Property(e => e.Failedchecktype5).HasColumnName("failedchecktype5");
            entity.Property(e => e.Failedchecktype6).HasColumnName("failedchecktype6");
            entity.Property(e => e.Failedchecktype7).HasColumnName("failedchecktype7");
            entity.Property(e => e.Percentchecktype1).HasColumnName("percentchecktype1");
            entity.Property(e => e.Percentchecktype2).HasColumnName("percentchecktype2");
            entity.Property(e => e.Percentchecktype3).HasColumnName("percentchecktype3");
            entity.Property(e => e.Percentchecktype4).HasColumnName("percentchecktype4");
            entity.Property(e => e.Percentchecktype5).HasColumnName("percentchecktype5");
            entity.Property(e => e.Percentchecktype6).HasColumnName("percentchecktype6");
            entity.Property(e => e.Percentchecktype7).HasColumnName("percentchecktype7");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MdlToolCohortrole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_cohortroles", tb => tb.HasComment("Mapping of users to cohort role assignments."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Cohortid, e.Roleid, e.Userid }, "mdl_toolcoho_cohroluse_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cohortid).HasColumnName("cohortid");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolCustomlang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_customlang", tb => tb.HasComment("Contains the working checkout of all strings and their custo"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Componentid, "mdl_toolcust_com_ix");

            entity.HasIndex(e => new { e.Lang, e.Componentid, e.Stringid }, "mdl_toolcust_lancomstr_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Componentid).HasColumnName("componentid");
            entity.Property(e => e.Lang)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("lang");
            entity.Property(e => e.Local).HasColumnName("local");
            entity.Property(e => e.Master).HasColumnName("master");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'0'")
                .HasColumnName("modified");
            entity.Property(e => e.Original).HasColumnName("original");
            entity.Property(e => e.Outdated)
                .HasDefaultValueSql("'0'")
                .HasColumnName("outdated");
            entity.Property(e => e.Stringid)
                .HasDefaultValueSql("''")
                .HasColumnName("stringid");
            entity.Property(e => e.Timecustomized).HasColumnName("timecustomized");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlToolCustomlangComponent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_customlang_components", tb => tb.HasComment("Contains the list of all installed plugins that provide thei"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlToolDataprivacyCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_dataprivacy_category", tb => tb.HasComment("Data categories"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolDataprivacyCtxexpired>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_dataprivacy_ctxexpired", tb => tb.HasComment("Default comment for the table, please edit me"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Contextid, "mdl_tooldatactxe_con_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Defaultexpired).HasColumnName("defaultexpired");
            entity.Property(e => e.Expiredroles).HasColumnName("expiredroles");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Unexpiredroles).HasColumnName("unexpiredroles");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolDataprivacyCtxinstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_dataprivacy_ctxinstance", tb => tb.HasComment("Default comment for the table, please edit me"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Categoryid, "mdl_tooldatactxi_cat_ix");

            entity.HasIndex(e => e.Contextid, "mdl_tooldatactxi_con_uix").IsUnique();

            entity.HasIndex(e => e.Purposeid, "mdl_tooldatactxi_pur_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Purposeid).HasColumnName("purposeid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolDataprivacyCtxlevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_dataprivacy_ctxlevel", tb => tb.HasComment("Default comment for the table, please edit me"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Categoryid, "mdl_tooldatactxl_cat_ix");

            entity.HasIndex(e => e.Contextlevel, "mdl_tooldatactxl_con_uix").IsUnique();

            entity.HasIndex(e => e.Purposeid, "mdl_tooldatactxl_pur_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Contextlevel).HasColumnName("contextlevel");
            entity.Property(e => e.Purposeid).HasColumnName("purposeid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolDataprivacyPurpose>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_dataprivacy_purpose", tb => tb.HasComment("Data purposes"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Lawfulbases).HasColumnName("lawfulbases");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Protected).HasColumnName("protected");
            entity.Property(e => e.Retentionperiod)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("retentionperiod");
            entity.Property(e => e.Sensitivedatareasons).HasColumnName("sensitivedatareasons");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolDataprivacyPurposerole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_dataprivacy_purposerole", tb => tb.HasComment("Data purpose overrides for a specific role"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Purposeid, "mdl_tooldatapurp_pur_ix");

            entity.HasIndex(e => new { e.Purposeid, e.Roleid }, "mdl_tooldatapurp_purrol_uix").IsUnique();

            entity.HasIndex(e => e.Roleid, "mdl_tooldatapurp_rol_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lawfulbases).HasColumnName("lawfulbases");
            entity.Property(e => e.Protected).HasColumnName("protected");
            entity.Property(e => e.Purposeid).HasColumnName("purposeid");
            entity.Property(e => e.Retentionperiod)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("retentionperiod");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Sensitivedatareasons).HasColumnName("sensitivedatareasons");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolDataprivacyRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_dataprivacy_request", tb => tb.HasComment("Table for data requests"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Dpo, "mdl_tooldatarequ_dpo_ix");

            entity.HasIndex(e => e.Requestedby, "mdl_tooldatarequ_req_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_tooldatarequ_use2_ix");

            entity.HasIndex(e => e.Userid, "mdl_tooldatarequ_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.Commentsformat).HasColumnName("commentsformat");
            entity.Property(e => e.Creationmethod).HasColumnName("creationmethod");
            entity.Property(e => e.Dpo)
                .HasDefaultValueSql("'0'")
                .HasColumnName("dpo");
            entity.Property(e => e.Dpocomment).HasColumnName("dpocomment");
            entity.Property(e => e.Dpocommentformat).HasColumnName("dpocommentformat");
            entity.Property(e => e.Requestedby).HasColumnName("requestedby");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Systemapproved).HasColumnName("systemapproved");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolMonitorEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_monitor_events", tb => tb.HasComment("A table that keeps a log of events related to subscriptions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contextid).HasColumnName("contextid");
            entity.Property(e => e.Contextinstanceid).HasColumnName("contextinstanceid");
            entity.Property(e => e.Contextlevel).HasColumnName("contextlevel");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Eventname)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("eventname");
            entity.Property(e => e.Link)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("link");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlToolMonitorHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_monitor_history", tb => tb.HasComment("Table to store history of message notifications sent"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Sid, "mdl_toolmonihist_sid_ix");

            entity.HasIndex(e => new { e.Sid, e.Userid, e.Timesent }, "mdl_toolmonihist_sidusetim_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Sid).HasColumnName("sid");
            entity.Property(e => e.Timesent).HasColumnName("timesent");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlToolMonitorRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_monitor_rules", tb => tb.HasComment("Table to store rules"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Courseid, e.Userid }, "mdl_toolmonirule_couuse_ix");

            entity.HasIndex(e => e.Eventname, "mdl_toolmonirule_eve_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Eventname)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("eventname");
            entity.Property(e => e.Frequency).HasColumnName("frequency");
            entity.Property(e => e.Name)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Plugin)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("plugin");
            entity.Property(e => e.Template).HasColumnName("template");
            entity.Property(e => e.Templateformat).HasColumnName("templateformat");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timewindow)
                .HasColumnType("mediumint")
                .HasColumnName("timewindow");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlToolMonitorSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_monitor_subscriptions", tb => tb.HasComment("Table to store user subscriptions to various rules"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Courseid, e.Userid }, "mdl_toolmonisubs_couuse_ix");

            entity.HasIndex(e => e.Ruleid, "mdl_toolmonisubs_rul_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cmid).HasColumnName("cmid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Inactivedate).HasColumnName("inactivedate");
            entity.Property(e => e.Lastnotificationsent).HasColumnName("lastnotificationsent");
            entity.Property(e => e.Ruleid).HasColumnName("ruleid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlToolPolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_policy", tb => tb.HasComment("Contains the list of policy documents defined on the site."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Currentversionid, "mdl_toolpoli_cur_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Currentversionid).HasColumnName("currentversionid");
            entity.Property(e => e.Sortorder)
                .HasDefaultValueSql("'999'")
                .HasColumnType("mediumint")
                .HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlToolPolicyAcceptance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_policy_acceptances", tb => tb.HasComment("Tracks users accepting the policy versions"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Policyversionid, "mdl_toolpoliacce_pol_ix");

            entity.HasIndex(e => new { e.Policyversionid, e.Userid }, "mdl_toolpoliacce_poluse_uix").IsUnique();

            entity.HasIndex(e => e.Usermodified, "mdl_toolpoliacce_use2_ix");

            entity.HasIndex(e => e.Userid, "mdl_toolpoliacce_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lang)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("lang");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Policyversionid).HasColumnName("policyversionid");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolPolicyVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_policy_versions", tb => tb.HasComment("Holds versions of the policy documents"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Policyid, "mdl_toolpolivers_pol_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_toolpolivers_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agreementstyle).HasColumnName("agreementstyle");
            entity.Property(e => e.Archived).HasColumnName("archived");
            entity.Property(e => e.Audience).HasColumnName("audience");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Contentformat).HasColumnName("contentformat");
            entity.Property(e => e.Name)
                .HasMaxLength(1333)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Optional).HasColumnName("optional");
            entity.Property(e => e.Policyid).HasColumnName("policyid");
            entity.Property(e => e.Revision)
                .HasMaxLength(1333)
                .HasDefaultValueSql("''")
                .HasColumnName("revision");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat).HasColumnName("summaryformat");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Usermodified).HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolRecyclebinCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_recyclebin_category", tb => tb.HasComment("A list of items in the category recycle bin"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Categoryid, "mdl_toolrecycate_cat_ix");

            entity.HasIndex(e => e.Timecreated, "mdl_toolrecycate_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Fullname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("fullname");
            entity.Property(e => e.Shortname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlToolRecyclebinCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_recyclebin_course", tb => tb.HasComment("A list of items in the course recycle bin"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_toolrecycour_cou_ix");

            entity.HasIndex(e => e.Timecreated, "mdl_toolrecycour_tim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Module).HasColumnName("module");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Section).HasColumnName("section");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlToolUsertoursStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_usertours_steps", tb => tb.HasComment("Steps in an tour"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Tourid, "mdl_tooluserstep_tou_ix");

            entity.HasIndex(e => new { e.Tourid, e.Sortorder }, "mdl_tooluserstep_tousor_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Configdata).HasColumnName("configdata");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Targettype).HasColumnName("targettype");
            entity.Property(e => e.Targetvalue).HasColumnName("targetvalue");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Tourid).HasColumnName("tourid");
        });

        modelBuilder.Entity<MdlToolUsertoursTour>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_tool_usertours_tours", tb => tb.HasComment("List of tours"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Configdata).HasColumnName("configdata");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Pathmatch)
                .HasMaxLength(255)
                .HasColumnName("pathmatch");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlUpgradeLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_upgrade_log", tb => tb.HasComment("Upgrade logging"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Timemodified, "mdl_upgrlog_tim_ix");

            entity.HasIndex(e => new { e.Type, e.Timemodified }, "mdl_upgrlog_typtim_ix");

            entity.HasIndex(e => e.Userid, "mdl_upgrlog_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Backtrace).HasColumnName("backtrace");
            entity.Property(e => e.Details).HasColumnName("details");
            entity.Property(e => e.Info)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("info");
            entity.Property(e => e.Plugin)
                .HasMaxLength(100)
                .HasColumnName("plugin");
            entity.Property(e => e.Targetversion)
                .HasMaxLength(100)
                .HasColumnName("targetversion");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Version)
                .HasMaxLength(100)
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlUrl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_url", tb => tb.HasComment("each record is one url resource"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_url_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Display).HasColumnName("display");
            entity.Property(e => e.Displayoptions).HasColumnName("displayoptions");
            entity.Property(e => e.Externalurl).HasColumnName("externalurl");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Parameters).HasColumnName("parameters");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_user", tb => tb.HasComment("One record for each person"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Alternatename, "mdl_user_alt_ix");

            entity.HasIndex(e => e.Auth, "mdl_user_aut_ix");

            entity.HasIndex(e => e.City, "mdl_user_cit_ix");

            entity.HasIndex(e => e.Confirmed, "mdl_user_con_ix");

            entity.HasIndex(e => e.Country, "mdl_user_cou_ix");

            entity.HasIndex(e => e.Deleted, "mdl_user_del_ix");

            entity.HasIndex(e => e.Email, "mdl_user_ema_ix");

            entity.HasIndex(e => e.Firstnamephonetic, "mdl_user_fir2_ix");

            entity.HasIndex(e => e.Firstname, "mdl_user_fir_ix");

            entity.HasIndex(e => e.Idnumber, "mdl_user_idn_ix");

            entity.HasIndex(e => e.Lastaccess, "mdl_user_las2_ix");

            entity.HasIndex(e => e.Lastnamephonetic, "mdl_user_las3_ix");

            entity.HasIndex(e => e.Lastname, "mdl_user_las_ix");

            entity.HasIndex(e => e.Middlename, "mdl_user_mid_ix");

            entity.HasIndex(e => new { e.Mnethostid, e.Username }, "mdl_user_mneuse_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("address");
            entity.Property(e => e.Alternatename).HasColumnName("alternatename");
            entity.Property(e => e.Auth)
                .HasMaxLength(20)
                .HasDefaultValueSql("'manual'")
                .HasColumnName("auth");
            entity.Property(e => e.Autosubscribe)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("autosubscribe");
            entity.Property(e => e.Calendartype)
                .HasMaxLength(30)
                .HasDefaultValueSql("'gregorian'")
                .HasColumnName("calendartype");
            entity.Property(e => e.City)
                .HasMaxLength(120)
                .HasDefaultValueSql("''")
                .HasColumnName("city");
            entity.Property(e => e.Confirmed).HasColumnName("confirmed");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .HasColumnName("country");
            entity.Property(e => e.Currentlogin).HasColumnName("currentlogin");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Department)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("department");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasDefaultValueSql("'1'")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.Emailstop).HasColumnName("emailstop");
            entity.Property(e => e.Firstaccess).HasColumnName("firstaccess");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("firstname");
            entity.Property(e => e.Firstnamephonetic).HasColumnName("firstnamephonetic");
            entity.Property(e => e.Idnumber)
                .HasDefaultValueSql("''")
                .HasColumnName("idnumber");
            entity.Property(e => e.Imagealt)
                .HasMaxLength(255)
                .HasColumnName("imagealt");
            entity.Property(e => e.Institution)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("institution");
            entity.Property(e => e.Lang)
                .HasMaxLength(30)
                .HasDefaultValueSql("'en'")
                .HasColumnName("lang");
            entity.Property(e => e.Lastaccess).HasColumnName("lastaccess");
            entity.Property(e => e.Lastip)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("lastip");
            entity.Property(e => e.Lastlogin).HasColumnName("lastlogin");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("lastname");
            entity.Property(e => e.Lastnamephonetic).HasColumnName("lastnamephonetic");
            entity.Property(e => e.Maildigest).HasColumnName("maildigest");
            entity.Property(e => e.Maildisplay)
                .HasDefaultValueSql("'2'")
                .HasColumnName("maildisplay");
            entity.Property(e => e.Mailformat)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("mailformat");
            entity.Property(e => e.Middlename).HasColumnName("middlename");
            entity.Property(e => e.Mnethostid).HasColumnName("mnethostid");
            entity.Property(e => e.Moodlenetprofile)
                .HasMaxLength(255)
                .HasColumnName("moodlenetprofile");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("password");
            entity.Property(e => e.Phone1)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("phone1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("phone2");
            entity.Property(e => e.Picture).HasColumnName("picture");
            entity.Property(e => e.Policyagreed).HasColumnName("policyagreed");
            entity.Property(e => e.Secret)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("secret");
            entity.Property(e => e.Suspended).HasColumnName("suspended");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("theme");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timezone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'99'")
                .HasColumnName("timezone");
            entity.Property(e => e.Trackforums).HasColumnName("trackforums");
            entity.Property(e => e.Trustbitmask).HasColumnName("trustbitmask");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<MdlUserDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_user_devices", tb => tb.HasComment("This table stores user's mobile devices information in order"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Pushid, e.Userid }, "mdl_userdevi_pususe_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_userdevi_use_ix");

            entity.HasIndex(e => new { e.Uuid, e.Userid }, "mdl_userdevi_uuiuse_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Appid)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("appid");
            entity.Property(e => e.Model)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("model");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Platform)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("platform");
            entity.Property(e => e.Pushid)
                .HasDefaultValueSql("''")
                .HasColumnName("pushid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Uuid)
                .HasDefaultValueSql("''")
                .HasColumnName("uuid");
            entity.Property(e => e.Version)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlUserEnrolment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_user_enrolments", tb => tb.HasComment("Users participating in courses (aka enrolled users) - everyb"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Enrolid, "mdl_userenro_enr_ix");

            entity.HasIndex(e => new { e.Enrolid, e.Userid }, "mdl_userenro_enruse_uix").IsUnique();

            entity.HasIndex(e => e.Modifierid, "mdl_userenro_mod_ix");

            entity.HasIndex(e => e.Userid, "mdl_userenro_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Enrolid).HasColumnName("enrolid");
            entity.Property(e => e.Modifierid).HasColumnName("modifierid");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timeend)
                .HasDefaultValueSql("'2147483647'")
                .HasColumnName("timeend");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timestart).HasColumnName("timestart");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlUserInfoCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_user_info_category", tb => tb.HasComment("Customisable fields categories"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlUserInfoDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_user_info_data", tb => tb.HasComment("Data for the customisable user fields"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Userid, e.Fieldid }, "mdl_userinfodata_usefie_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Dataformat).HasColumnName("dataformat");
            entity.Property(e => e.Fieldid).HasColumnName("fieldid");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlUserInfoField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_user_info_field", tb => tb.HasComment("Customisable user profile fields"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Datatype)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("datatype");
            entity.Property(e => e.Defaultdata).HasColumnName("defaultdata");
            entity.Property(e => e.Defaultdataformat).HasColumnName("defaultdataformat");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Forceunique).HasColumnName("forceunique");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Param1).HasColumnName("param1");
            entity.Property(e => e.Param2).HasColumnName("param2");
            entity.Property(e => e.Param3).HasColumnName("param3");
            entity.Property(e => e.Param4).HasColumnName("param4");
            entity.Property(e => e.Param5).HasColumnName("param5");
            entity.Property(e => e.Required).HasColumnName("required");
            entity.Property(e => e.Shortname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'shortname'")
                .HasColumnName("shortname");
            entity.Property(e => e.Signup).HasColumnName("signup");
            entity.Property(e => e.Sortorder).HasColumnName("sortorder");
            entity.Property(e => e.Visible).HasColumnName("visible");
        });

        modelBuilder.Entity<MdlUserLastaccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_user_lastaccess", tb => tb.HasComment("To keep track of course page access times, used in online pa"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Courseid, "mdl_userlast_cou_ix");

            entity.HasIndex(e => e.Userid, "mdl_userlast_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Courseid }, "mdl_userlast_usecou_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Timeaccess).HasColumnName("timeaccess");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlUserPasswordHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_user_password_history", tb => tb.HasComment("A rotating log of hashes of previously used passwords for ea"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Userid, "mdl_userpasshist_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Hash)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("hash");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlUserPasswordReset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_user_password_resets", tb => tb.HasComment("table tracking password reset confirmation tokens"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Userid, "mdl_userpassrese_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Timerequested).HasColumnName("timerequested");
            entity.Property(e => e.Timererequested).HasColumnName("timererequested");
            entity.Property(e => e.Token)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("token");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlUserPreference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_user_preferences", tb => tb.HasComment("Allows modules to store arbitrary user preferences"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Name, "mdl_userpref_nam_ix");

            entity.HasIndex(e => new { e.Userid, e.Name }, "mdl_userpref_usenam_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Value)
                .HasMaxLength(1333)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlUserPrivateKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_user_private_key", tb => tb.HasComment("access keys used in cookieless scripts - rss, etc."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Script, e.Value }, "mdl_userprivkey_scrval_ix");

            entity.HasIndex(e => e.Userid, "mdl_userprivkey_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Instance).HasColumnName("instance");
            entity.Property(e => e.Iprestriction)
                .HasMaxLength(255)
                .HasColumnName("iprestriction");
            entity.Property(e => e.Script)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("script");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Validuntil).HasColumnName("validuntil");
            entity.Property(e => e.Value)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlWiki>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_wiki", tb => tb.HasComment("Stores Wiki activity configuration"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_wiki_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Defaultformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'creole'")
                .HasColumnName("defaultformat");
            entity.Property(e => e.Editbegin).HasColumnName("editbegin");
            entity.Property(e => e.Editend)
                .HasDefaultValueSql("'0'")
                .HasColumnName("editend");
            entity.Property(e => e.Firstpagetitle)
                .HasMaxLength(255)
                .HasDefaultValueSql("'First Page'")
                .HasColumnName("firstpagetitle");
            entity.Property(e => e.Forceformat)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("forceformat");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("'Wiki'")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Wikimode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'collaborative'")
                .HasColumnName("wikimode");
        });

        modelBuilder.Entity<MdlWikiLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_wiki_links", tb => tb.HasComment("Page wiki links"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Frompageid, "mdl_wikilink_fro_ix");

            entity.HasIndex(e => e.Subwikiid, "mdl_wikilink_sub_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Frompageid).HasColumnName("frompageid");
            entity.Property(e => e.Subwikiid).HasColumnName("subwikiid");
            entity.Property(e => e.Tomissingpage)
                .HasMaxLength(255)
                .HasColumnName("tomissingpage");
            entity.Property(e => e.Topageid).HasColumnName("topageid");
        });

        modelBuilder.Entity<MdlWikiLock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_wiki_locks", tb => tb.HasComment("Manages page locks"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lockedat).HasColumnName("lockedat");
            entity.Property(e => e.Pageid).HasColumnName("pageid");
            entity.Property(e => e.Sectionname)
                .HasMaxLength(255)
                .HasColumnName("sectionname");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlWikiPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_wiki_pages", tb => tb.HasComment("Stores wiki pages"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Subwikiid, "mdl_wikipage_sub_ix");

            entity.HasIndex(e => new { e.Subwikiid, e.Title, e.Userid }, "mdl_wikipage_subtituse_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cachedcontent).HasColumnName("cachedcontent");
            entity.Property(e => e.Pageviews).HasColumnName("pageviews");
            entity.Property(e => e.Readonly).HasColumnName("readonly");
            entity.Property(e => e.Subwikiid).HasColumnName("subwikiid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timerendered).HasColumnName("timerendered");
            entity.Property(e => e.Title)
                .HasDefaultValueSql("'title'")
                .HasColumnName("title");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlWikiSubwiki>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_wiki_subwikis", tb => tb.HasComment("Stores subwiki instances"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Wikiid, "mdl_wikisubw_wik_ix");

            entity.HasIndex(e => new { e.Wikiid, e.Groupid, e.Userid }, "mdl_wikisubw_wikgrouse_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Wikiid).HasColumnName("wikiid");
        });

        modelBuilder.Entity<MdlWikiSynonym>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_wiki_synonyms", tb => tb.HasComment("Stores wiki pages synonyms"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Pageid, e.Pagesynonym }, "mdl_wikisyno_pagpag_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Pageid).HasColumnName("pageid");
            entity.Property(e => e.Pagesynonym)
                .HasDefaultValueSql("'Pagesynonym'")
                .HasColumnName("pagesynonym");
            entity.Property(e => e.Subwikiid).HasColumnName("subwikiid");
        });

        modelBuilder.Entity<MdlWikiVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_wiki_versions", tb => tb.HasComment("Stores wiki page history"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Pageid, "mdl_wikivers_pag_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Contentformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'creole'")
                .HasColumnName("contentformat");
            entity.Property(e => e.Pageid).HasColumnName("pageid");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Version)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint")
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlWorkshop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshop", tb => tb.HasComment("This table keeps information about the module instances and "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Course, "mdl_work_cou_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assessmentend)
                .HasDefaultValueSql("'0'")
                .HasColumnName("assessmentend");
            entity.Property(e => e.Assessmentstart)
                .HasDefaultValueSql("'0'")
                .HasColumnName("assessmentstart");
            entity.Property(e => e.Conclusion).HasColumnName("conclusion");
            entity.Property(e => e.Conclusionformat)
                .HasDefaultValueSql("'1'")
                .HasColumnName("conclusionformat");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.Evaluation)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("evaluation");
            entity.Property(e => e.Examplesmode)
                .HasDefaultValueSql("'0'")
                .HasColumnName("examplesmode");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'80.00000'")
                .HasColumnName("grade");
            entity.Property(e => e.Gradedecimals)
                .HasDefaultValueSql("'0'")
                .HasColumnName("gradedecimals");
            entity.Property(e => e.Gradinggrade)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'20.00000'")
                .HasColumnName("gradinggrade");
            entity.Property(e => e.Instructauthors).HasColumnName("instructauthors");
            entity.Property(e => e.Instructauthorsformat).HasColumnName("instructauthorsformat");
            entity.Property(e => e.Instructreviewers).HasColumnName("instructreviewers");
            entity.Property(e => e.Instructreviewersformat).HasColumnName("instructreviewersformat");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.Latesubmissions)
                .HasDefaultValueSql("'0'")
                .HasColumnName("latesubmissions");
            entity.Property(e => e.Maxbytes)
                .HasDefaultValueSql("'100000'")
                .HasColumnName("maxbytes");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Nattachments)
                .HasDefaultValueSql("'1'")
                .HasColumnName("nattachments");
            entity.Property(e => e.Overallfeedbackfiles)
                .HasDefaultValueSql("'0'")
                .HasColumnName("overallfeedbackfiles");
            entity.Property(e => e.Overallfeedbackfiletypes)
                .HasMaxLength(255)
                .HasColumnName("overallfeedbackfiletypes");
            entity.Property(e => e.Overallfeedbackmaxbytes)
                .HasDefaultValueSql("'100000'")
                .HasColumnName("overallfeedbackmaxbytes");
            entity.Property(e => e.Overallfeedbackmode)
                .HasDefaultValueSql("'1'")
                .HasColumnName("overallfeedbackmode");
            entity.Property(e => e.Phase)
                .HasDefaultValueSql("'0'")
                .HasColumnName("phase");
            entity.Property(e => e.Phaseswitchassessment).HasColumnName("phaseswitchassessment");
            entity.Property(e => e.Strategy)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("strategy");
            entity.Property(e => e.Submissionend)
                .HasDefaultValueSql("'0'")
                .HasColumnName("submissionend");
            entity.Property(e => e.Submissionfiletypes)
                .HasMaxLength(255)
                .HasColumnName("submissionfiletypes");
            entity.Property(e => e.Submissionstart)
                .HasDefaultValueSql("'0'")
                .HasColumnName("submissionstart");
            entity.Property(e => e.Submissiontypefile)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("submissiontypefile");
            entity.Property(e => e.Submissiontypetext)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("submissiontypetext");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Useexamples)
                .HasDefaultValueSql("'0'")
                .HasColumnName("useexamples");
            entity.Property(e => e.Usepeerassessment)
                .HasDefaultValueSql("'0'")
                .HasColumnName("usepeerassessment");
            entity.Property(e => e.Useselfassessment)
                .HasDefaultValueSql("'0'")
                .HasColumnName("useselfassessment");
        });

        modelBuilder.Entity<MdlWorkshopAggregation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshop_aggregations", tb => tb.HasComment("Aggregated grades for assessment are stored here. The aggreg"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Userid, "mdl_workaggr_use_ix");

            entity.HasIndex(e => e.Workshopid, "mdl_workaggr_wor_ix");

            entity.HasIndex(e => new { e.Workshopid, e.Userid }, "mdl_workaggr_woruse_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Gradinggrade)
                .HasPrecision(10, 5)
                .HasColumnName("gradinggrade");
            entity.Property(e => e.Timegraded).HasColumnName("timegraded");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Workshopid).HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopAssessment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshop_assessments", tb => tb.HasComment("Info about the made assessment and automatically calculated "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Gradinggradeoverby, "mdl_workasse_gra_ix");

            entity.HasIndex(e => e.Reviewerid, "mdl_workasse_rev_ix");

            entity.HasIndex(e => e.Submissionid, "mdl_workasse_sub_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Feedbackauthor).HasColumnName("feedbackauthor");
            entity.Property(e => e.Feedbackauthorattachment)
                .HasDefaultValueSql("'0'")
                .HasColumnName("feedbackauthorattachment");
            entity.Property(e => e.Feedbackauthorformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("feedbackauthorformat");
            entity.Property(e => e.Feedbackreviewer).HasColumnName("feedbackreviewer");
            entity.Property(e => e.Feedbackreviewerformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("feedbackreviewerformat");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Gradinggrade)
                .HasPrecision(10, 5)
                .HasColumnName("gradinggrade");
            entity.Property(e => e.Gradinggradeover)
                .HasPrecision(10, 5)
                .HasColumnName("gradinggradeover");
            entity.Property(e => e.Gradinggradeoverby).HasColumnName("gradinggradeoverby");
            entity.Property(e => e.Reviewerid).HasColumnName("reviewerid");
            entity.Property(e => e.Submissionid).HasColumnName("submissionid");
            entity.Property(e => e.Timecreated)
                .HasDefaultValueSql("'0'")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasDefaultValueSql("'0'")
                .HasColumnName("timemodified");
            entity.Property(e => e.Weight)
                .HasDefaultValueSql("'1'")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<MdlWorkshopGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshop_grades", tb => tb.HasComment("How the reviewers filled-up the grading forms, given grades "))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Assessmentid, "mdl_workgrad_ass_ix");

            entity.HasIndex(e => new { e.Assessmentid, e.Strategy, e.Dimensionid }, "mdl_workgrad_assstrdim_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assessmentid).HasColumnName("assessmentid");
            entity.Property(e => e.Dimensionid).HasColumnName("dimensionid");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Peercomment).HasColumnName("peercomment");
            entity.Property(e => e.Peercommentformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("peercommentformat");
            entity.Property(e => e.Strategy)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("strategy");
        });

        modelBuilder.Entity<MdlWorkshopSubmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshop_submissions", tb => tb.HasComment("Info about the submission and the aggregation of the grade f"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Authorid, "mdl_worksubm_aut_ix");

            entity.HasIndex(e => e.Gradeoverby, "mdl_worksubm_gra_ix");

            entity.HasIndex(e => e.Workshopid, "mdl_worksubm_wor_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attachment)
                .HasDefaultValueSql("'0'")
                .HasColumnName("attachment");
            entity.Property(e => e.Authorid).HasColumnName("authorid");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Contentformat).HasColumnName("contentformat");
            entity.Property(e => e.Contenttrust).HasColumnName("contenttrust");
            entity.Property(e => e.Example)
                .HasDefaultValueSql("'0'")
                .HasColumnName("example");
            entity.Property(e => e.Feedbackauthor).HasColumnName("feedbackauthor");
            entity.Property(e => e.Feedbackauthorformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("feedbackauthorformat");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Gradeover)
                .HasPrecision(10, 5)
                .HasColumnName("gradeover");
            entity.Property(e => e.Gradeoverby).HasColumnName("gradeoverby");
            entity.Property(e => e.Late).HasColumnName("late");
            entity.Property(e => e.Published)
                .HasDefaultValueSql("'0'")
                .HasColumnName("published");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timegraded).HasColumnName("timegraded");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.Workshopid).HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopallocationScheduled>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshopallocation_scheduled", tb => tb.HasComment("Stores the allocation settings for the scheduled allocator"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Workshopid, "mdl_worksche_wor_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Resultlog).HasColumnName("resultlog");
            entity.Property(e => e.Resultmessage)
                .HasMaxLength(1333)
                .HasColumnName("resultmessage");
            entity.Property(e => e.Resultstatus).HasColumnName("resultstatus");
            entity.Property(e => e.Settings).HasColumnName("settings");
            entity.Property(e => e.Submissionend).HasColumnName("submissionend");
            entity.Property(e => e.Timeallocated).HasColumnName("timeallocated");
            entity.Property(e => e.Workshopid).HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopevalBestSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshopeval_best_settings", tb => tb.HasComment("Settings for the grading evaluation subplugin Comparison wit"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Workshopid, "mdl_workbestsett_wor_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comparison)
                .HasDefaultValueSql("'5'")
                .HasColumnName("comparison");
            entity.Property(e => e.Workshopid).HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformAccumulative>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshopform_accumulative", tb => tb.HasComment("The assessment dimensions definitions of Accumulative gradin"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Workshopid, "mdl_workaccu_wor_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("'0'")
                .HasColumnName("sort");
            entity.Property(e => e.Weight)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("weight");
            entity.Property(e => e.Workshopid).HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshopform_comments", tb => tb.HasComment("The assessment dimensions definitions of Comments strategy f"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Workshopid, "mdl_workcomm_wor_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("'0'")
                .HasColumnName("sort");
            entity.Property(e => e.Workshopid).HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformNumerror>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshopform_numerrors", tb => tb.HasComment("The assessment dimensions definitions of Number of errors gr"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Workshopid, "mdl_worknume_wor_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Descriptiontrust).HasColumnName("descriptiontrust");
            entity.Property(e => e.Grade0)
                .HasMaxLength(50)
                .HasColumnName("grade0");
            entity.Property(e => e.Grade1)
                .HasMaxLength(50)
                .HasColumnName("grade1");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("'0'")
                .HasColumnName("sort");
            entity.Property(e => e.Weight)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint")
                .HasColumnName("weight");
            entity.Property(e => e.Workshopid).HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformNumerrorsMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshopform_numerrors_map", tb => tb.HasComment("This maps the number of errors to a percentual grade for sub"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Workshopid, "mdl_worknumemap_wor_ix");

            entity.HasIndex(e => new { e.Workshopid, e.Nonegative }, "mdl_worknumemap_wornon_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Nonegative).HasColumnName("nonegative");
            entity.Property(e => e.Workshopid).HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformRubric>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshopform_rubric", tb => tb.HasComment("The assessment dimensions definitions of Rubric grading stra"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Workshopid, "mdl_workrubr_wor_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("'0'")
                .HasColumnName("sort");
            entity.Property(e => e.Workshopid).HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformRubricConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshopform_rubric_config", tb => tb.HasComment("Configuration table for the Rubric grading strategy"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Workshopid, "mdl_workrubrconf_wor_uix").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Layout)
                .HasMaxLength(30)
                .HasDefaultValueSql("'list'")
                .HasColumnName("layout");
            entity.Property(e => e.Workshopid).HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformRubricLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_workshopform_rubric_levels", tb => tb.HasComment("The definition of rubric rating scales"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Dimensionid, "mdl_workrubrleve_dim_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Definitionformat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("definitionformat");
            entity.Property(e => e.Dimensionid).HasColumnName("dimensionid");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
        });

        modelBuilder.Entity<MdlZoom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_zoom", tb => tb.HasComment("Zoom meetings and webinars"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.MeetingId, "mdl_zoom_mee_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AlternativeHosts).HasColumnName("alternative_hosts");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.CreatedAt)
                .HasMaxLength(20)
                .HasColumnName("created_at");
            entity.Property(e => e.Duration)
                .HasColumnType("mediumint")
                .HasColumnName("duration");
            entity.Property(e => e.EndDateOption).HasColumnName("end_date_option");
            entity.Property(e => e.EndDateTime).HasColumnName("end_date_time");
            entity.Property(e => e.EndTimes).HasColumnName("end_times");
            entity.Property(e => e.ExistsOnZoom)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("exists_on_zoom");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.HostId)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("host_id");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat).HasColumnName("introformat");
            entity.Property(e => e.JoinUrl).HasColumnName("join_url");
            entity.Property(e => e.MeetingId).HasColumnName("meeting_id");
            entity.Property(e => e.MonthlyDay).HasColumnName("monthly_day");
            entity.Property(e => e.MonthlyRepeatOption).HasColumnName("monthly_repeat_option");
            entity.Property(e => e.MonthlyWeek).HasColumnName("monthly_week");
            entity.Property(e => e.MonthlyWeekDay).HasColumnName("monthly_week_day");
            entity.Property(e => e.Name)
                .HasMaxLength(300)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.OptionAudio)
                .HasMaxLength(9)
                .HasDefaultValueSql("'both'")
                .HasColumnName("option_audio");
            entity.Property(e => e.OptionAuthenticatedUsers)
                .HasDefaultValueSql("'0'")
                .HasColumnName("option_authenticated_users");
            entity.Property(e => e.OptionAutoRecording)
                .HasMaxLength(5)
                .HasColumnName("option_auto_recording");
            entity.Property(e => e.OptionEncryptionType)
                .HasMaxLength(20)
                .HasDefaultValueSql("'enhanced_encryption'")
                .HasColumnName("option_encryption_type");
            entity.Property(e => e.OptionHostVideo)
                .HasDefaultValueSql("'0'")
                .HasColumnName("option_host_video");
            entity.Property(e => e.OptionJbh)
                .HasDefaultValueSql("'0'")
                .HasColumnName("option_jbh");
            entity.Property(e => e.OptionMuteUponEntry)
                .HasDefaultValueSql("'1'")
                .HasColumnName("option_mute_upon_entry");
            entity.Property(e => e.OptionParticipantsVideo)
                .HasDefaultValueSql("'0'")
                .HasColumnName("option_participants_video");
            entity.Property(e => e.OptionStartType)
                .HasMaxLength(12)
                .HasColumnName("option_start_type");
            entity.Property(e => e.OptionWaitingRoom)
                .HasDefaultValueSql("'1'")
                .HasColumnName("option_waiting_room");
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .HasColumnName("password");
            entity.Property(e => e.RecordingsVisibleDefault)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("recordings_visible_default");
            entity.Property(e => e.RecurrenceType).HasColumnName("recurrence_type");
            entity.Property(e => e.Recurring)
                .HasDefaultValueSql("'0'")
                .HasColumnName("recurring");
            entity.Property(e => e.Registration)
                .IsRequired()
                .HasDefaultValueSql("'2'")
                .HasColumnName("registration");
            entity.Property(e => e.RepeatInterval).HasColumnName("repeat_interval");
            entity.Property(e => e.ShowMedia)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("show_media");
            entity.Property(e => e.ShowSchedule)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("show_schedule");
            entity.Property(e => e.ShowSecurity)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("show_security");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.StartUrl).HasColumnName("start_url");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Timezone)
                .HasMaxLength(50)
                .HasColumnName("timezone");
            entity.Property(e => e.Webinar)
                .HasDefaultValueSql("'0'")
                .HasColumnName("webinar");
            entity.Property(e => e.WeeklyDays)
                .HasMaxLength(14)
                .HasColumnName("weekly_days");
        });

        modelBuilder.Entity<MdlZoomBreakoutGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_zoom_breakout_groups", tb => tb.HasComment("A list of zoom meeting breakout rooms groups."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Breakoutroomid, "mdl_zoombreagrou_bre_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Breakoutroomid).HasColumnName("breakoutroomid");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
        });

        modelBuilder.Entity<MdlZoomBreakoutParticipant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_zoom_breakout_participants", tb => tb.HasComment("A list of zoom meeting breakout rooms participants."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Breakoutroomid, "mdl_zoombreapart_bre_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Breakoutroomid).HasColumnName("breakoutroomid");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<MdlZoomMeetingBreakoutRoom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_zoom_meeting_breakout_rooms", tb => tb.HasComment("A list of zoom meeting breakout rooms."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Zoomid, "mdl_zoommeetbrearoom_zoo_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
            entity.Property(e => e.Zoomid).HasColumnName("zoomid");
        });

        modelBuilder.Entity<MdlZoomMeetingDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_zoom_meeting_details", tb => tb.HasComment("A queue for the Cron to add meeting report info to zoom_meet"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Uuid, "mdl_zoommeetdeta_uui_uix").IsUnique();

            entity.HasIndex(e => e.Zoomid, "mdl_zoommeetdeta_zoo_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.MeetingId).HasColumnName("meeting_id");
            entity.Property(e => e.ParticipantsCount)
                .HasDefaultValueSql("'0'")
                .HasColumnName("participants_count");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.Topic)
                .HasMaxLength(300)
                .HasDefaultValueSql("''")
                .HasColumnName("topic");
            entity.Property(e => e.TotalMinutes)
                .HasDefaultValueSql("'0'")
                .HasColumnName("total_minutes");
            entity.Property(e => e.Uuid)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("uuid");
            entity.Property(e => e.Zoomid).HasColumnName("zoomid");
        });

        modelBuilder.Entity<MdlZoomMeetingParticipant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_zoom_meeting_participants", tb => tb.HasComment("A list of each meeting existing on Moodle and when its parti"))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Detailsid, "mdl_zoommeetpart_det_ix");

            entity.HasIndex(e => e.Userid, "mdl_zoommeetpart_use_ix");

            entity.HasIndex(e => e.Uuid, "mdl_zoommeetpart_uui_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Detailsid).HasColumnName("detailsid");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.JoinTime).HasColumnName("join_time");
            entity.Property(e => e.LeaveTime).HasColumnName("leave_time");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.UserEmail).HasColumnName("user_email");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Uuid)
                .HasMaxLength(30)
                .HasColumnName("uuid");
            entity.Property(e => e.Zoomuserid)
                .HasMaxLength(35)
                .HasDefaultValueSql("''")
                .HasColumnName("zoomuserid");
        });

        modelBuilder.Entity<MdlZoomMeetingRecording>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_zoom_meeting_recordings", tb => tb.HasComment("A list of recording links for Zoom meeting activities."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Zoomid, "mdl_zoommeetreco_zoo_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Externalurl).HasColumnName("externalurl");
            entity.Property(e => e.Meetinguuid)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("meetinguuid");
            entity.Property(e => e.Name)
                .HasMaxLength(300)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Passcode)
                .HasMaxLength(30)
                .HasColumnName("passcode");
            entity.Property(e => e.Recordingstart).HasColumnName("recordingstart");
            entity.Property(e => e.Recordingtype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("recordingtype");
            entity.Property(e => e.Showrecording).HasColumnName("showrecording");
            entity.Property(e => e.Timecreated).HasColumnName("timecreated");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Zoomid).HasColumnName("zoomid");
            entity.Property(e => e.Zoomrecordingid)
                .HasMaxLength(36)
                .HasDefaultValueSql("''")
                .HasColumnName("zoomrecordingid");
        });

        modelBuilder.Entity<MdlZoomMeetingRecordingsView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_zoom_meeting_recordings_view", tb => tb.HasComment("A list to track when users view Zoom meeting recordings."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Recordingsid, "mdl_zoommeetrecoview_rec_ix");

            entity.HasIndex(e => e.Userid, "mdl_zoommeetrecoview_use_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Recordingsid).HasColumnName("recordingsid");
            entity.Property(e => e.Timemodified).HasColumnName("timemodified");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Viewed).HasColumnName("viewed");
        });

        modelBuilder.Entity<MdlZoomMeetingTrackingField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mdl_zoom_meeting_tracking_fields", tb => tb.HasComment("A list of tracking field values for meetings in Zoom."))
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.MeetingId, "mdl_zoommeettracfiel_mee_ix");

            entity.HasIndex(e => e.TrackingField, "mdl_zoommeettracfiel_tra_ix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MeetingId).HasColumnName("meeting_id");
            entity.Property(e => e.TrackingField)
                .HasDefaultValueSql("''")
                .HasColumnName("tracking_field");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
