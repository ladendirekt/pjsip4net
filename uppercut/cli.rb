require 'FileUtils'
require 'thor'

module Uppercutbuild
  class CLI < Thor
	  include Thor::Actions
	
  	def initialize(*)
  		super
  		
  		@proj = Uppercutbuild::Project.new
  	end
	
    desc "initialize", "initializes uppercut build in the current directory"
	  method_options :location => :string
    def init(*names)
		#@proj.ensure_default_config
		
  		loc = @proj.get_location
  		cl = options['location']
  		loc = cl unless cl.nil?
		
			Uppercutbuild::Loader.load
      puts "UppercuT has been added to this project. Please look through the lib directory for items you don't need. NAnt is still required at the current time."
    end
    
    desc "upgrade", "upgrades the uppercut 'build' directory"
	  method_options :location => :string
    def upgrade(*names)
		#@proj.ensure_default_config
		
  		loc = @proj.get_location
  		cl = options['location']
  		loc = cl unless cl.nil?
		
			Uppercutbuild::Loader.upgrade
      puts "The build folder has been updated. Please check the release logs for items outside of this folder that may need to be updated."
    end
	
  	def self.source_root
  		File.dirname(__FILE__)
  	end
	
  end
end