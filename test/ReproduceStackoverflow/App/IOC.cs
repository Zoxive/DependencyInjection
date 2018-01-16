using System;
using Microsoft.Extensions.DependencyInjection;
namespace App
{

	public static class RegisterIOC
	{
	public static IServiceCollection Register(this IServiceCollection services)
	{
		services.AddScoped<IKeystoneUserDao,KeystoneUserDao>();
		services.AddScoped<IFieldValidatorService,AfterValidatorService>();
		services.AddScoped<IFieldValidatorService,BeforeValidatorService>();
		services.AddScoped<IFieldValidatorService,BooleanValidatorService>();
		services.AddScoped<IFieldValidatorService,CaseCorrectionValidatorService>();
		services.AddScoped<IFieldValidatorService,DecimalValidatorService>();
		services.AddScoped<IFieldValidatorService,GuidValidatorService>();
		services.AddScoped<IFieldValidatorService,MaxLengthValidatorService>();
		services.AddScoped<IFieldValidatorService,RangeValidatorService>();
		services.AddScoped<IFieldValidatorService,RegexValidatorService>();
		services.AddScoped<IFieldValidatorService,RequiredValidatorService>();
		services.AddScoped<IFieldValidatorService,ScaleValidatorService>();
		services.AddScoped<IFieldValidatorService,StringValidatorService>();
		services.AddScoped<IFieldValidatorService,UniqueValidatorService>();
		services.AddScoped<ReadAncestorsStep,ReadAncestorsStep>();
		services.AddScoped<IHookpointErrorRepository,HookpointErrorRepository>();
		services.AddScoped<ReadRootStep,ReadRootStep>();
		services.AddScoped<IKeystoneEntityNameResolver,HardCodedEntity>();
		services.AddScoped<IDocumentManagementService,DocumentManagementService>();
		services.AddScoped<UpdateResourceStep,UpdateResourceStep>();
		services.AddScoped<IHookpointErrorMapper,HookpointErrorMapper>();
		services.AddScoped<IEntityRecordService,EntityRecordService>();
		services.AddScoped<IDataType,BoolDataType>();
		services.AddScoped<IDataType,DateTimeDataType>();
		services.AddScoped<IDataType,EmailDataType>();
		services.AddScoped<IDataType,NumberDataType>();
		services.AddScoped<IDataType,SequenceDataType>();
		services.AddScoped<IDataType,StringDataType>();
		services.AddScoped<IRecordAssignmentsService,RecordAssignmentsService>();
		services.AddScoped<ITraceEventListenerFactory,TraceEventListenerFactory>();
		services.AddScoped<ILocaleDao,LocaleDao>();
		services.AddScoped<IHookpointExecutionService,HookpointExecutionService>();
		services.AddScoped<RestrictDeleteStep,RestrictDeleteStep>();
		services.AddScoped<IContentFactory,ContentFactory>();
		services.AddScoped<IEntityRecordResourceDao,EntityRecordResourceDao>();
		services.AddScoped<IAsyncActionMessagePublishEventFactory,AsyncActionMessagePublishEventFactory>();
		services.AddScoped<IContentHeaderFactory,ContentHeaderFactory>();
		services.AddScoped<IBackgroundTaskCurrentUserProxyFactory,BackgroundTaskCurrentUserProxyFactory>();
		services.AddScoped<KeystoneApplicationStatus,KeystoneApplicationStatus>();
		services.AddScoped<IODataSearchParametersFactory,ODataSearchParametersFactory>();
		services.AddScoped<IReadStep,ReadStep>();
		services.AddScoped<IManyToManyRecordValidationService,ManyToManyRecordValidationService>();
		services.AddScoped<IContentValidationService,ContentValidationService>();
		services.AddScoped<ITracingRuleExecutingAggregateService,TracingRuleExecutingAggregateService>();
		services.AddScoped<IEntityRecordServiceImpl,EntityRecordServiceImpl>();
		services.AddScoped<ITraceSettingsRepository,TraceSettingsRepository>();
		services.AddScoped<IAsyncActionRecordListener,AsyncActionRecordListener>();
		services.AddScoped<DeleteStep,DeleteStep>();
		services.AddScoped<ReadAllStep,ReadAllStep>();
		services.AddScoped<IAsyncActionRecordChangeEventFactory,AsyncActionRecordChangeEventFactory>();
		services.AddScoped<IAuthorizedEntityRecordService,AuthorizedEntityRecordService>();
		services.AddScoped<IEntityRecordSequenceFieldService,EntityRecordSequenceFieldService>();
		services.AddScoped<IRuleTypeRepository,RuleTypeRepository>();
		services.AddScoped<IKeystoneApplicationDatabase,ApplicationDatabase>();
		services.AddScoped<IKeystoneUserRepository,KeystoneUserRepository>();
		services.AddScoped<HookpointErrorDelegatingHandler,HookpointErrorDelegatingHandler>();
		services.AddScoped<IUpdateStep,UpdateStep>();
		services.AddScoped<IEntityFieldValidatorFactory,EntityFieldValidatorFactory>();
		services.AddScoped<OnLoginSystemHookpointStep,OnLoginSystemHookpointStep>();
		services.AddScoped<CopyStep,CopyStep>();

        services.AddScoped(typeof(IGenericEngineFactory<,>), typeof(AuthenticatedEngineFactory<,>));

		services.AddScoped<AddMetadataStep,AddMetadataStep>();
		services.AddScoped<IContentFacade,ContentFacade>();
		services.AddScoped<ISystemHookpointDao,SystemHookpointDao>();
		services.AddScoped<IEntityRecordServiceImplFactory,EntityRecordServiceImplFactory>();
		services.AddScoped<EntityRecordService,EntityRecordService>();
		services.AddScoped<IContentFieldModifiedEventListener,ContentFieldModifiedEventListener>();
		services.AddScoped<IIdmContentService,IdmContentService>();
		services.AddScoped<IUserRepository,UserRepository>();

		services.AddScoped<IEntityRecordMetadataFactoryFactory,EntityRecordMetadataFactoryFactory>();

		services.AddScoped<IUsageMetricsService,UsageMetricsService>();
		services.AddScoped<ResilientRecordsDelegatingHandler,ResilientRecordsDelegatingHandler>();
		services.AddScoped<ICompositeEntityRecordServiceImpl,CompositeEntityRecordServiceImpl>();
		services.AddScoped<IContentRepository,ContentRepository>();
		services.AddScoped<IKeystoneApplicationTableCacherFactory,KeystoneApplicationTableCacherFactory>();
		services.AddScoped<IEntityRecordNotificationHandler,EntityRecordNotificationHandler>();
		services.AddScoped<IPerKeystoneApplicationCacheManager,PerKeystoneApplicationCacheManager>();
		services.AddScoped<IHookpointExecuteEventFactory,HookpointExecuteEventFactory>();
		services.AddScoped<ITraceActionExecutionService,TraceActionExecutionService>();
		services.AddScoped<IEntityFieldValidationService,EntityFieldValidationService>();
		services.AddScoped<IEntityActionResultBuilder,EntityActionResultBuilder>();
		services.AddScoped<DateTime,DateTime>();
		services.AddScoped<IManyToManyRecordUpdateService,ManyToManyRecordUpdateService>();
		services.AddScoped<IEntityRecordReadAncestorsService,EntityRecordReadAncestorsService>();
		services.AddScoped<ApplyAuthorizationStep,ApplyAuthorizationStep>();
		services.AddScoped<IAsyncActionEventsFactory,AsyncActionEventsFactory>();
		services.AddScoped<IEntityUrlHelper,EntityUrlHelper>();
		services.AddScoped<RootRulesetEntityAction,RootRulesetEntityAction>();
		services.AddScoped<IEntityRecordRepository,EntityRecordRepository>();
		services.AddScoped<IEntityRecordReadAllService,EntityRecordReadAllService>();
		services.AddScoped<IAsyncActionRepository,AsyncActionRepository>();
		services.AddScoped<IKeystoneApplicationRowCacherFactory,KeystoneApplicationRowCacherFactory>();
		services.AddScoped<KeystoneProduct,KeystoneProduct>();
		services.AddScoped<IAsyncActionDao,AsyncActionDao>();
		services.AddScoped<IFunctionRulesetRepository,FunctionRulesetRepository>();
		services.AddScoped<IKeystoneApplicationNameResolver,HardCodedApplicationNameResolver>();
		services.AddScoped<IUsageMetricsEventAggregator,UsageMetricsEventAggregator>();
		services.AddScoped<ISystemHookpointExecutionService,SystemHookpointExecutionService>();
		services.AddScoped<ServiceProviderEngine,ServiceProviderEngine>();
		services.AddScoped<IEntityRecordEventsNormalizer,EntityRecordEventsNormalizer>();
		services.AddScoped<ISaveStep,SaveStep>();
		services.AddScoped<IRulesetExecutionContextFactory,RulesetExecutionContextFactory>();
		services.AddScoped<IBackgroundTaskQueueService,BackgroundTaskQueueService>();
		services.AddScoped<IEntityDatabaseDefinitionFactory,SecureEntityDatabaseDefinitionFactory>();
		services.AddScoped<KeystoneTenant,KeystoneTenant>();

		services.AddScoped<IEntityRecordMetadataFactory<IEntityDefinition>,EntityRecordMetadataFactory>();
		services.AddScoped<IEntityRecordMetadataFactory<IManyToManyEntityDefinition>, ManyToManyMetadataFactory>();
		services.AddScoped<IEntityRecordMetadataFactory<IUnionEntityDefinition>, UnionMetadataFactory>();
		services.AddScoped<IEntityRecordMetadataEventsFactory,EntityRecordMetadataEventsFactory>();

		services.AddScoped<ITraceExpressionEventFactory,TraceExpressionEventFactory>();
		services.AddScoped<IEntityRecordActionExecutionServiceFactory,EntityRecordActionExecutionServiceFactory>();
		services.AddScoped<IHookpointErrorDao,HookpointErrorDao>();
		services.AddScoped<IUserFactory,UserFactory>();
		services.AddScoped<IAggregateRootModifiedRepository,AggregateRootModifiedRepository>();


		services.AddScoped<IExceptionDetailDao,ExceptionDetailDao>();
		services.AddScoped<IClientDataFactory,ClientDataFactory>();
		services.AddScoped<IEntityRecordContentService,EntityRecordContentService>();
		services.AddScoped<IExceptionDetailMapper,ExceptionDetailMapper>();
		services.AddScoped<IContentIdmLinkDao,ContentIdmLinkDao>();
		services.AddScoped<IExceptionDetailRepository,ExceptionDetailRepository>();
		services.AddScoped<IEntityActionEventAggregator,EntityActionEventAggregator>();
		services.AddScoped<IEntityActionStepProcessor,EntityActionStepProcessor>();
		services.AddScoped<IUsageMetricsDao,UsageMetricsDao>();
		services.AddScoped<SaveChangedUserDelegatingHandler,SaveChangedUserDelegatingHandler>();
		services.AddScoped<IPublishedEntityDefinitionDao,PublishedEntityDefinitionDao>();
		services.AddScoped<IEntityRecordValidator,EntityRecordValidator>();
		services.AddScoped<IEntityFieldXmlSerializer,EntityFieldXmlSerializer>();
		services.AddScoped<ILinkFactory,LinkFactory>();
		services.AddScoped<IGenericEngineSettingsService,GenericEngineSettingsService>();
		services.AddScoped<IKeystoneAdminDatabase,Database>();
		services.AddScoped<IUsageMetricsRuleEventAggregator,UsageMetricsRuleEventAggregator>();
		services.AddScoped<IEntityAction,Copy>();
		services.AddScoped<Copy>();
		services.AddScoped<IEntityAction,Create>();
		services.AddScoped<Create>();
		services.AddScoped<IEntityAction,Delete>();
		services.AddScoped<Delete>();
		services.AddScoped<IEntityAction,Read>();
		services.AddScoped<Read>();
		services.AddScoped<IEntityAction,ReadAll>();
		services.AddScoped<ReadAll>();
		services.AddScoped<IEntityAction,ReadAncestors>();
		services.AddScoped<ReadAncestors>();
		services.AddScoped<IEntityAction,Update>();
		services.AddScoped<Update>();
		services.AddScoped<IEntityAction,RulesetEntityAction>();
		services.AddScoped<RulesetEntityAction>();
		services.AddScoped<IEntityRecordCache,EntityRecordCache>();
		services.AddScoped<IKeystoneSectionVersionRepository,KeystoneSectionVersionRepository>();
		services.AddScoped<ISystemHookpointScheduledRulesetDelegator,SystemHookpointScheduledRulesetDelegator>();
		services.AddScoped<UpdateResource>();
		services.AddScoped<IResilientRecordDao,ResilientRecordDao>();
		services.AddScoped<IEntityDefinitionRepository,EntityDefinitionRepository>();
		services.AddScoped<ISaveAllStep,SaveAllStep>();
		services.AddScoped<IRuleEngineExceptionMessageFactory,RuleEngineExceptionMessageFactory>();
		services.AddScoped<ApplyNonPersistedFieldValuesStep,ApplyNonPersistedFieldValuesStep>();
		services.AddScoped<IUserDao,UserDao>();
		services.AddScoped<ExitOnErrorStep,ExitOnErrorStep>();
		services.AddScoped<IEntityRecordResourceService,EntityRecordResourceService>();
		services.AddScoped<ICurrentUser,HardCodedCurrentUser>();

		services.AddScoped<IHookpointErrorInMemoryRepository,HookpointErrorInMemoryRepository>();

		services.AddScoped<IEntityActionsFactory, EntityActionsFactory>();

		services.AddScoped<IValidationXmlSerializer,ValidationXmlSerializer>();
		services.AddScoped<IManyToManyEntityRecordServiceImpl,ManyToManyEntityRecordServiceImpl>();
		services.AddScoped<IDataSource,DataSource>();
		services.AddScoped<IGenericEngineExecutionService,GenericEngineExecutionService>();
		services.AddScoped<IIdmDocumentFactory,IdmDocumentFactory>();
		services.AddScoped<CreateStep,CreateStep>();
		services.AddScoped<IODataQueryBuilder,ODataQueryBuilder>();
		services.AddScoped<DecimalValidatorService,DecimalValidatorService>();
		services.AddScoped<ILinkRelationActionService,LinkRelationActionService>();
		services.AddScoped<ValidateAllStep,ValidateAllStep>();
		services.AddScoped<IResilientRecordRepository,ResilientRecordRepository>();
		services.AddScoped<NameValueCollection,NameValueCollection>();
		services.AddScoped<IKeystoneUserDtoFactory,KeystoneUserDtoFactory>();
		services.AddScoped<IKeystoneAdminUnitOfWorkFactory,KeystoneAdminUnitOfWorkFactory>();
		services.AddScoped<IEngineValueToStringFactory,EngineValueToStringFactory>();
		services.AddScoped<IUnionEntityRecordServiceImpl,UnionEntityRecordServiceImpl>();
		services.AddScoped<IUsageMetricsFactory,UsageMetricsFactory>();
		services.AddScoped<IEngineValueToJObjectFactory,EngineValueToJObjectFactory>();
		services.AddScoped<IAsyncActionFactory,AsyncActionFactory>();
		services.AddScoped<IEntityDefinitionXmlSerializer,EntityDefinitionXmlSerializer>();
		services.AddScoped<IETagCache,ETagCache>();
		services.AddScoped<IEntityActionEventListenerFactory,EntityActionEventListenerFactory>();
		services.AddScoped<IKeystoneUserService,KeystoneUserService>();

        // TODO wrapped cache
		services.AddScoped<IRulesetRepository,CachedRulesetRepository>();
	    services.AddScoped<IRulesetDao, RulesetDao>();

		services.AddScoped<IHttpContextAccessor,HardCodedHttpContextAccessor>();
		services.AddScoped<IEntityRecordResourceRepository,EntityRecordResourceRepository>();
		services.AddScoped<IEntityActionRepository,EntityActionRepository>();
		services.AddScoped<ApplyAssignmentsStep,ApplyAssignmentsStep>();
		services.AddScoped<IEntityRecordDefaultValuesGenerator,EntityRecordDefaultValuesGenerator>();
		services.AddScoped<IAggregateRootModifiedEventListener,AggregateRootModifiedEventListener>();
		services.AddScoped<IEntityRecordQueryBuilder,EntityRecordQueryBuilder>();
		services.AddScoped<IEntityRecordFactory,EntityRecordFactory>();
		services.AddScoped<IUserService,UserService>();
		services.AddScoped<ITraceSettingsDao,TraceSettingsDao>();
		services.AddScoped<ValidateStep,ValidateStep>();
		services.AddScoped<IAsyncActionsService,AsyncActionsService>();
		services.AddScoped<IContentDao,ContentDao>();
		services.AddScoped<ITraceWriterFactory,TraceWriterFactory>();
		services.AddScoped<IAuthorizationService,AuthorizationService>();
		services.AddScoped<IODataLogicalOperatorSqlParser,ODataLogicalOperatorSqlParser>();
		services.AddScoped<CopyCurrentRecordToOriginalRecordStep,CopyCurrentRecordToOriginalRecordStep>();
		services.AddScoped<IEntityActionResultFactory,EntityActionResultFactory>();
		services.AddScoped<IHookpointErrorFactory,HookpointErrorFactory>();
		services.AddScoped<IContentService,ContentService>();
		services.AddScoped<IManyToManyEntityRecordMetadataFactoryImpl,ManyToManyEntityRecordMetadataFactoryImpl>();
		services.AddScoped<IEntityRecordQueryBuilderFactory,EntityRecordQueryBuilderFactory>();
		services.AddScoped<IDocumentManagementApi,NullDocumentManagementApi>();
		services.AddScoped<ISystemHookpointRepository,SystemHookpointRepository>();
		services.AddScoped<IContentIdmLinkFactory,ContentIdmLinkFactory>();
		services.AddScoped<IConnectionFactory,AuthorizedConnectionFactory>();
		services.AddScoped<IEntityActionDelegator,EntityActionDelegator>();
		services.AddScoped<ApplyResourceAssignmentsStep,ApplyResourceAssignmentsStep>();
		services.AddScoped<KeystoneApplication,KeystoneApplication>();
		services.AddScoped<IEntityActionEventListener,EntityActionEventListener>();

		services.AddScoped<IEntityHookpointStepFactory,EntityHookpointStepFactory>();
	    services.AddScoped<IGenericExpressionValueLookup, GenericExpressionValueLookup>();

		services.AddScoped<IContentIdmLinkRepository,ContentIdmLinkRepository>();
		services.AddScoped<IODataParser,ODataPocoSqlParser>();
		services.AddScoped<TraceDelegatingHandler,TraceDelegatingHandler>();
		services.AddScoped<IUsageMetricsRecordCrudCounterSerializer,UsageMetricsRecordCrudCounterSerializer>();
		services.AddScoped<IFunctionRulesetFactory,FunctionRulesetFactory>();
		services.AddScoped<IKeystoneUnitOfWorkFactory,KeystoneUnitOfWorkFactory>();
		services.AddScoped<IUsageMetricsRepository,UsageMetricsRepository>();
		services.AddScoped<UsageMetricsDelegatingHandler,UsageMetricsDelegatingHandler>();
		services.AddScoped<IUsageMetricsRecordCrudCountsFactory,UsageMetricsRecordCrudCountsFactory>();
		services.AddScoped<IFunctionRulesetDao,FunctionRulesetDao>();
		services.AddScoped<IContentEntityLinkFactory,ContentEntityLinkFactory>();
		services.AddScoped<EntityRecordsController,EntityRecordsController>();

		services.AddScoped<IEntityRecordDao,EntityRecordDao>();
	    services.AddScoped<EntityDatabaseDefinitionFactory, EntityDatabaseDefinitionFactory>();
	    services.AddScoped<IEntityRecordDtoFactory, EntityRecordDtoFactory>();

		services.AddScoped<IConfigurationManagerAppSettingsRepository,ConfigurationManagerAppSettingsRepository>();
		services.AddScoped<ISystemHookpointFactory,SystemHookpointFactory>();
		services.AddScoped<IBackgroundTaskQueueParamsDtoFactory,BackgroundTaskQueueParamsDtoFactory>();
		services.AddScoped<SetDefaultValuesStep,SetDefaultValuesStep>();
		services.AddScoped<IEntityRecordManyToManyQueryBuilder,EntityRecordManyToManyQueryBuilder>();
		services.AddScoped<ClearOrDefaultUniqueValuesStep,ClearOrDefaultUniqueValuesStep>();
		services.AddScoped<ReadRoot,ReadRoot>();
		services.AddScoped<IManyToManySelectBuilder,ManyToManySelectBuilder>();
	return services;
	}
	}

}
