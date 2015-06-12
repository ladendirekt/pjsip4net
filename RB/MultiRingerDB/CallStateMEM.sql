/*
The database must have a MEMORY_OPTIMIZED_DATA filegroup
before the memory optimized object can be created.

The bucket count should be set to about two times the 
maximum expected number of distinct values in the 
index key, rounded up to the nearest power of two.
*/

CREATE TABLE [dbo].[CallStateMEM]
(
    [CallStateId] INT NOT NULL PRIMARY KEY NONCLUSTERED HASH WITH (BUCKET_COUNT = 131072), 
    [Call-ID] VARCHAR(64)  COLLATE Latin1_General_100_BIN2 NOT NULL INDEX [IX_CallState_Call-ID] HASH ([Call-ID]) WITH (BUCKET_COUNT = 131072), 
    [From] VARCHAR(64) NOT NULL, 
    [To] VARCHAR(64) NOT NULL, 
    [CSeq] VARCHAR(16) NOT NULL, 
    [Via] VARCHAR(64) NOT NULL,  
    [Contact] VARCHAR(64) NOT NULL, 
    [timestamp] DATETIME2 NOT NULL INDEX [ix_timestamp] HASH WITH (BUCKET_COUNT=1000000) 
   
) WITH (MEMORY_OPTIMIZED = ON, DURABILITY = SCHEMA_AND_DATA)